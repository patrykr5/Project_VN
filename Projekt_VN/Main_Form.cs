using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IronOcr;

namespace Projekt_VN
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void SkanOCR()
        {
            var Ocr = new AdvancedOcr();
            {

            };
            
            DialogResult dr = ofs_Ocr.ShowDialog();

            if (dr == DialogResult.OK)
            {
                //przypisanie zmiennej Result do wyniku przetworzenia przez OCR pliku wskazanego za pomocą ofs_Ocr
                var Result = Ocr.Read(ImageFilePath: ofs_Ocr.FileName);
                DialogResult drs = sfd_Text.ShowDialog();
                if (drs == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd_Text.FileName))
                    {
                        //zapis wyniku z ocr do pliku tekstowego
                        sw.Write(Result);
                    }
                }
            }
        }

        public string text;

        private void PrzetworzonyTxt()
        {

            DialogResult dr = ofs_Ocr.ShowDialog();
            if (dr == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofs_Ocr.FileName))
                {
                    //przypisanie do zmiennej text (string) wartosci ze wskazanego pliku za pomoca ofs_Ocr
                    text = sr.ReadLine();
                }
            }
        }

        private void oAplikacjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tworzenie nowego okna i przypisanie do af
            About_Form af = new About_Form();
            af.ShowDialog();
        }


        private void Main_Form_Load(object sender, EventArgs e)
        {
            //zablokowanie opcji w menu rozwijanym, do czasu skonczenia autoryzacji XXXXXXXXX
            czynnościAdmToolStripMenuItem.Enabled = false;
            tsl_UserLogon.Text = "Login: " + User.LoginL();
            sfd_Text.DefaultExt = ".txt";
            sfd_Text.Filter = "Dokument tekstowy (.txt)|*.txt";
        }

        private void btm_Scannow_Click(object sender, EventArgs e)
        {
            SkanOCR();
        }

        private void btm_Preprocess_Click(object sender, EventArgs e)
        {
            //((DataRowView)(fVSelectBindingSource.Current)).Row.SetField<int>("UserID", User.ID);
            PrzetworzonyTxt();
            if (ofs_Ocr.FileName != "openFileDialog1")
            {
                btm_Preprocess.Enabled = false;
                lb_Kolejnoscdzialan.Visible = true;
                this.fVSelectBindingSource.AddNew();
                string podatek_vat = string.Empty;
                string kwota_brutto = string.Empty;
                string terminplatnosci = "";
                string length = "aaaaaaaaaa";
                int lengthcount;
                lengthcount = length.Length;
                string data = "";
                foreach (string line in File.ReadLines(ofs_Ocr.FileName))
                {
                    if (line.Contains("USD") & line.Contains("Total"))
                    {
                        kwota_brutto = line;
                    }
                    if (line.Contains("%"))
                    {
                        podatek_vat = line;
                    }
                    if (line.Contains("-") & line.Length == lengthcount)
                    {
                        data = line;
                    }
                    if (line.Contains("Due date"))
                    {
                        terminplatnosci = line;
                    }
                }
                //wygenerowanie zmiennych pomocniczych
                char abc = ',';
                char dfe = '%';
                string var1 = podatek_vat;
                string alpha1 = string.Empty;
                string numer1 = string.Empty;
                //odseparowanie wartości podatku ze stringa
                foreach (char str in var1)
                {
                    if (char.IsDigit(str) || str.Equals(dfe))
                        if (str.Equals('%'))
                            break;
                        else
                            numer1 += str.ToString();

                    else
                        alpha1 += str.ToString();
                }
                string test2 = "23";
                string wynik = string.Empty;
                wynik = numer1.Remove(0, numer1.Length - 2);
                if (wynik != test2)
                    wynik = numer1.Remove(0, numer1.Length - 1);
                //zmienne pomocnicze
                string var = kwota_brutto;
                string alpha = string.Empty;
                string numer = string.Empty;
                string terminp = string.Empty;
                //odczytwanie wartości brutto ze stringa
                foreach (char str in var)
                {
                    if (char.IsDigit(str) || str.Equals(abc))
                        numer += str.ToString();
                    else
                        alpha += str.ToString();
                }
                //zamiana kwoty brutto na decimal
                decimal decimalnumber = Convert.ToDecimal(numer.Replace(".", ","));
                //petla szukajaca w string terminu platnosci
                foreach (char str in terminplatnosci)
                {
                    if (char.IsDigit(str))
                    {
                        terminp += str.ToString();
                    }
                }
                //przypisanie wynikow z analizy pliku do textbox'ow
                DateTime fdata = Convert.ToDateTime(data);
                DateTime ftermin = fdata.AddDays(Convert.ToInt32(terminp));
                tb_DataWystawienia.Text = fdata.ToString();
                tb_TerminPlatnosci.Text = ftermin.ToString();
                tb_Vat.Text = wynik;
                tb_Kwota.Text = numer;
            }
            else
            {
                MessageBox.Show("Musisz wskazać plik do przetworzenia.", "Ostrzeżenie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btm_DodajDB_Click(object sender, EventArgs e)
        {                    
            //sprawdza czy textboxy są puste, jeśli tak to wyświetla komunikat, jeśli nie to dodaje do bazy
            if (string.IsNullOrWhiteSpace(tb.Text) || 
                string.IsNullOrWhiteSpace(tb_Nazwa.Text) ||
                string.IsNullOrWhiteSpace(tb_Ulica.Text) ||
                string.IsNullOrWhiteSpace(tb_NrDom.Text) ||
                string.IsNullOrWhiteSpace(tb_Kod.Text) ||
                string.IsNullOrWhiteSpace(tb_Miasto.Text) ||
                string.IsNullOrWhiteSpace(tb_DataWystawienia.Text) ||
                string.IsNullOrWhiteSpace(tb_TerminPlatnosci.Text) ||
                string.IsNullOrWhiteSpace(tb_Vat.Text) ||
                string.IsNullOrWhiteSpace(tb_Kwota.Text))
            {
                MessageBox.Show("Pola z sekcji Dane Uzupełniajace nie mogą być puste!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Validate();
                this.fVSelectBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dBProjekt_VNDataSet);
                btm_Preprocess.Enabled = true;
                lb_Kolejnoscdzialan.Visible = false;
            }
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bazaDanychToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB_Form bazaform = new DB_Form();
            bazaform.ShowDialog();
        }
    }
}
