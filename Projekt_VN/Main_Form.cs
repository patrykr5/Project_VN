using System;
using System.Windows.Forms;
using System.IO;
using IronOcr;
using Projekt_VN.Models;
using Projekt_VN.Controllers;

namespace Projekt_VN
{
    public partial class Main_Form : Form
    {
        public string ProcessedText { get; private set; }
        private OcrController _ocrController;

        public Main_Form()
        {
            InitializeComponent();
            _ocrController = new OcrController();
        }

        private void OcrScan()
        {
            AdvancedOcr advancedOcr = new AdvancedOcr();
            DialogResult dialogResult = ofs_Ocr.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                var ocrResult = advancedOcr.Read(ImageFilePath: ofs_Ocr.FileName);
                DialogResult saveFileDialogResult = sfd_Text.ShowDialog();
                if (saveFileDialogResult == DialogResult.OK)
                {
                    using (StreamWriter streamWriter = new StreamWriter(sfd_Text.FileName))
                    {
                        streamWriter.Write(ocrResult);
                    }
                }
            }
        }

        private void SaveOfProcessedText()
        {
            DialogResult dialogResult = ofs_Ocr.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                using (StreamReader streamReader = new StreamReader(ofs_Ocr.FileName))
                {
                    ProcessedText = streamReader.ReadLine();
                }
            }
        }

        private void oAplikacjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Form aboutForm = new About_Form();
            aboutForm.ShowDialog();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            czynnościAdmToolStripMenuItem.Enabled = false;
            tsl_UserLogon.Text = string.Concat("Login: ", _ocrController.GetLoginOfLoggedUser());
            sfd_Text.DefaultExt = ".txt";
            sfd_Text.Filter = "Dokument tekstowy (.txt)|*.txt";
        }

        private void btm_Scannow_Click(object sender, EventArgs e)
        {
            OcrScan();
        }

        private void btm_Preprocess_Click(object sender, EventArgs e)
        {
            //((DataRowView)(fVSelectBindingSource.Current)).Row.SetField<int>("UserID", User.ID);
            SaveOfProcessedText();
            if (ofs_Ocr.FileName != "openFileDialog1")
            {
                PrepareControls(false);
                this.fVSelectBindingSource.AddNew();

                PreprocessDataModel preprocessDataModel = _ocrController.PreprocessData(File.ReadLines(ofs_Ocr.FileName),
                                                                                        "aaaaaaaaaa");
                tb_DataWystawienia.Text = preprocessDataModel.DateOfIssueOfDocument.ToString();
                tb_TerminPlatnosci.Text = preprocessDataModel.PaymentDate.ToString();
                tb_Vat.Text = preprocessDataModel.Tax;
                tb_Kwota.Text = preprocessDataModel.Cost.ToString();
            }
            else
            {
                MessageBox.Show("Musisz wskazać plik do przetworzenia.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btm_DodajDB_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Pola z sekcji Dane Uzupełniajace nie mogą być puste!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Validate();
                this.fVSelectBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dBProjekt_VNDataSet);
                PrepareControls(true);
            }
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bazaDanychToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB_Form databaseForm = new DB_Form();
            databaseForm.ShowDialog();
        }

        private void PrepareControls(bool whetherButtonFromPreprocessSupposedToBeEnabled)
        {
            btm_Preprocess.Enabled = whetherButtonFromPreprocessSupposedToBeEnabled;
            lb_Kolejnoscdzialan.Visible = !whetherButtonFromPreprocessSupposedToBeEnabled;
        }
    }
}
