namespace Projekt_VN
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ms_FMenu = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funkcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czynnościAdmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaDanychToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikacjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_FInfo = new System.Windows.Forms.ToolStrip();
            this.tsl_UserLogon = new System.Windows.Forms.ToolStripLabel();
            this.sfd_Text = new System.Windows.Forms.SaveFileDialog();
            this.btm_Scannow = new System.Windows.Forms.Button();
            this.ofs_Ocr = new System.Windows.Forms.OpenFileDialog();
            this.btm_Preprocess = new System.Windows.Forms.Button();
            this.gb_Glowne = new System.Windows.Forms.GroupBox();
            this.lb_Kolejnoscdzialan = new System.Windows.Forms.Label();
            this.gb_Pola = new System.Windows.Forms.GroupBox();
            this.lb_ID = new System.Windows.Forms.Label();
            this.fVSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBProjekt_VNDataSet = new Projekt_VN.DBProjekt_VNDataSet();
            this.tb_Kwota = new System.Windows.Forms.TextBox();
            this.lb_Kwota = new System.Windows.Forms.Label();
            this.tb_Vat = new System.Windows.Forms.TextBox();
            this.lb_Vat = new System.Windows.Forms.Label();
            this.tb_TerminPlatnosci = new System.Windows.Forms.TextBox();
            this.lb_Termin = new System.Windows.Forms.Label();
            this.tb_DataWystawienia = new System.Windows.Forms.TextBox();
            this.lb_Data = new System.Windows.Forms.Label();
            this.btm_DodajDB = new System.Windows.Forms.Button();
            this.tb_Miasto = new System.Windows.Forms.TextBox();
            this.lb_Miasto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Kod = new System.Windows.Forms.TextBox();
            this.tb_NrDom = new System.Windows.Forms.TextBox();
            this.lb_NrDom = new System.Windows.Forms.Label();
            this.tb_Ulica = new System.Windows.Forms.TextBox();
            this.lb_Ulica = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.lb_NIP = new System.Windows.Forms.Label();
            this.tb_Nazwa = new System.Windows.Forms.TextBox();
            this.lb_Nazwa = new System.Windows.Forms.Label();
            this.fVSelectTableAdapter = new Projekt_VN.DBProjekt_VNDataSetTableAdapters.FVSelectTableAdapter();
            this.tableAdapterManager = new Projekt_VN.DBProjekt_VNDataSetTableAdapters.TableAdapterManager();
            this.ms_FMenu.SuspendLayout();
            this.ts_FInfo.SuspendLayout();
            this.gb_Glowne.SuspendLayout();
            this.gb_Pola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fVSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProjekt_VNDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_FMenu
            // 
            this.ms_FMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.funkcjeToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.ms_FMenu.Location = new System.Drawing.Point(0, 0);
            this.ms_FMenu.Name = "ms_FMenu";
            this.ms_FMenu.Size = new System.Drawing.Size(596, 24);
            this.ms_FMenu.TabIndex = 0;
            this.ms_FMenu.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // funkcjeToolStripMenuItem
            // 
            this.funkcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.czynnościAdmToolStripMenuItem,
            this.bazaDanychToolStripMenuItem});
            this.funkcjeToolStripMenuItem.Name = "funkcjeToolStripMenuItem";
            this.funkcjeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.funkcjeToolStripMenuItem.Text = "Funkcje";
            // 
            // czynnościAdmToolStripMenuItem
            // 
            this.czynnościAdmToolStripMenuItem.Enabled = false;
            this.czynnościAdmToolStripMenuItem.Name = "czynnościAdmToolStripMenuItem";
            this.czynnościAdmToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.czynnościAdmToolStripMenuItem.Text = "Czynności adm.";
            this.czynnościAdmToolStripMenuItem.Visible = false;
            // 
            // bazaDanychToolStripMenuItem
            // 
            this.bazaDanychToolStripMenuItem.Name = "bazaDanychToolStripMenuItem";
            this.bazaDanychToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.bazaDanychToolStripMenuItem.Text = "Moduł DB";
            this.bazaDanychToolStripMenuItem.Click += new System.EventHandler(this.bazaDanychToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oAplikacjiToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // oAplikacjiToolStripMenuItem
            // 
            this.oAplikacjiToolStripMenuItem.Name = "oAplikacjiToolStripMenuItem";
            this.oAplikacjiToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.oAplikacjiToolStripMenuItem.Text = "O aplikacji...";
            this.oAplikacjiToolStripMenuItem.Click += new System.EventHandler(this.oAplikacjiToolStripMenuItem_Click);
            // 
            // ts_FInfo
            // 
            this.ts_FInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ts_FInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_UserLogon});
            this.ts_FInfo.Location = new System.Drawing.Point(0, 436);
            this.ts_FInfo.Name = "ts_FInfo";
            this.ts_FInfo.Size = new System.Drawing.Size(596, 25);
            this.ts_FInfo.TabIndex = 1;
            this.ts_FInfo.Text = "toolStrip1";
            // 
            // tsl_UserLogon
            // 
            this.tsl_UserLogon.Name = "tsl_UserLogon";
            this.tsl_UserLogon.Size = new System.Drawing.Size(70, 22);
            this.tsl_UserLogon.Text = "Login: none";
            // 
            // sfd_Text
            // 
            this.sfd_Text.DefaultExt = "*.txt";
            // 
            // btm_Scannow
            // 
            this.btm_Scannow.Location = new System.Drawing.Point(12, 28);
            this.btm_Scannow.Name = "btm_Scannow";
            this.btm_Scannow.Size = new System.Drawing.Size(75, 23);
            this.btm_Scannow.TabIndex = 2;
            this.btm_Scannow.Text = "Skanuj";
            this.btm_Scannow.UseVisualStyleBackColor = true;
            this.btm_Scannow.Click += new System.EventHandler(this.btm_Scannow_Click);
            // 
            // ofs_Ocr
            // 
            this.ofs_Ocr.FileName = "openFileDialog1";
            // 
            // btm_Preprocess
            // 
            this.btm_Preprocess.Location = new System.Drawing.Point(216, 28);
            this.btm_Preprocess.Name = "btm_Preprocess";
            this.btm_Preprocess.Size = new System.Drawing.Size(75, 23);
            this.btm_Preprocess.TabIndex = 3;
            this.btm_Preprocess.Text = "Przetwórz";
            this.btm_Preprocess.UseVisualStyleBackColor = true;
            this.btm_Preprocess.Click += new System.EventHandler(this.btm_Preprocess_Click);
            // 
            // gb_Glowne
            // 
            this.gb_Glowne.Controls.Add(this.lb_Kolejnoscdzialan);
            this.gb_Glowne.Controls.Add(this.btm_Preprocess);
            this.gb_Glowne.Controls.Add(this.btm_Scannow);
            this.gb_Glowne.Location = new System.Drawing.Point(12, 51);
            this.gb_Glowne.Name = "gb_Glowne";
            this.gb_Glowne.Size = new System.Drawing.Size(545, 80);
            this.gb_Glowne.TabIndex = 4;
            this.gb_Glowne.TabStop = false;
            this.gb_Glowne.Text = "Funkcje OCR";
            // 
            // lb_Kolejnoscdzialan
            // 
            this.lb_Kolejnoscdzialan.AutoSize = true;
            this.lb_Kolejnoscdzialan.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_Kolejnoscdzialan.Location = new System.Drawing.Point(216, 58);
            this.lb_Kolejnoscdzialan.Name = "lb_Kolejnoscdzialan";
            this.lb_Kolejnoscdzialan.Size = new System.Drawing.Size(197, 13);
            this.lb_Kolejnoscdzialan.TabIndex = 4;
            this.lb_Kolejnoscdzialan.Text = "Dodaj najpierw dane, aby kontynuować.";
            this.lb_Kolejnoscdzialan.Visible = false;
            // 
            // gb_Pola
            // 
            this.gb_Pola.Controls.Add(this.lb_ID);
            this.gb_Pola.Controls.Add(this.tb_Kwota);
            this.gb_Pola.Controls.Add(this.lb_Kwota);
            this.gb_Pola.Controls.Add(this.tb_Vat);
            this.gb_Pola.Controls.Add(this.lb_Vat);
            this.gb_Pola.Controls.Add(this.tb_TerminPlatnosci);
            this.gb_Pola.Controls.Add(this.lb_Termin);
            this.gb_Pola.Controls.Add(this.tb_DataWystawienia);
            this.gb_Pola.Controls.Add(this.lb_Data);
            this.gb_Pola.Controls.Add(this.btm_DodajDB);
            this.gb_Pola.Controls.Add(this.tb_Miasto);
            this.gb_Pola.Controls.Add(this.lb_Miasto);
            this.gb_Pola.Controls.Add(this.label1);
            this.gb_Pola.Controls.Add(this.tb_Kod);
            this.gb_Pola.Controls.Add(this.tb_NrDom);
            this.gb_Pola.Controls.Add(this.lb_NrDom);
            this.gb_Pola.Controls.Add(this.tb_Ulica);
            this.gb_Pola.Controls.Add(this.lb_Ulica);
            this.gb_Pola.Controls.Add(this.tb);
            this.gb_Pola.Controls.Add(this.lb_NIP);
            this.gb_Pola.Controls.Add(this.tb_Nazwa);
            this.gb_Pola.Controls.Add(this.lb_Nazwa);
            this.gb_Pola.Location = new System.Drawing.Point(12, 151);
            this.gb_Pola.Name = "gb_Pola";
            this.gb_Pola.Size = new System.Drawing.Size(545, 278);
            this.gb_Pola.TabIndex = 5;
            this.gb_Pola.TabStop = false;
            this.gb_Pola.Text = "Dane uzupełniające";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fVSelectBindingSource, "Id", true));
            this.lb_ID.Location = new System.Drawing.Point(166, 30);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(18, 13);
            this.lb_ID.TabIndex = 21;
            this.lb_ID.Text = "ID";
            this.lb_ID.Visible = false;
            // 
            // fVSelectBindingSource
            // 
            this.fVSelectBindingSource.DataMember = "FVSelect";
            this.fVSelectBindingSource.DataSource = this.dBProjekt_VNDataSet;
            // 
            // dBProjekt_VNDataSet
            // 
            this.dBProjekt_VNDataSet.DataSetName = "DBProjekt_VNDataSet";
            this.dBProjekt_VNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_Kwota
            // 
            this.tb_Kwota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fVSelectBindingSource, "Wartość_brutto", true));
            this.tb_Kwota.Location = new System.Drawing.Point(454, 174);
            this.tb_Kwota.Name = "tb_Kwota";
            this.tb_Kwota.Size = new System.Drawing.Size(85, 20);
            this.tb_Kwota.TabIndex = 20;
            // 
            // lb_Kwota
            // 
            this.lb_Kwota.AutoSize = true;
            this.lb_Kwota.Location = new System.Drawing.Point(408, 177);
            this.lb_Kwota.Name = "lb_Kwota";
            this.lb_Kwota.Size = new System.Drawing.Size(40, 13);
            this.lb_Kwota.TabIndex = 19;
            this.lb_Kwota.Text = "Kwota:";
            // 
            // tb_Vat
            // 
            this.tb_Vat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fVSelectBindingSource, "Vat", true));
            this.tb_Vat.Location = new System.Drawing.Point(369, 174);
            this.tb_Vat.Name = "tb_Vat";
            this.tb_Vat.Size = new System.Drawing.Size(33, 20);
            this.tb_Vat.TabIndex = 18;
            // 
            // lb_Vat
            // 
            this.lb_Vat.AutoSize = true;
            this.lb_Vat.Location = new System.Drawing.Point(332, 177);
            this.lb_Vat.Name = "lb_Vat";
            this.lb_Vat.Size = new System.Drawing.Size(31, 13);
            this.lb_Vat.TabIndex = 17;
            this.lb_Vat.Text = "VAT:";
            // 
            // tb_TerminPlatnosci
            // 
            this.tb_TerminPlatnosci.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fVSelectBindingSource, "Termin", true));
            this.tb_TerminPlatnosci.Location = new System.Drawing.Point(216, 174);
            this.tb_TerminPlatnosci.Name = "tb_TerminPlatnosci";
            this.tb_TerminPlatnosci.Size = new System.Drawing.Size(110, 20);
            this.tb_TerminPlatnosci.TabIndex = 16;
            // 
            // lb_Termin
            // 
            this.lb_Termin.AutoSize = true;
            this.lb_Termin.Location = new System.Drawing.Point(178, 177);
            this.lb_Termin.Name = "lb_Termin";
            this.lb_Termin.Size = new System.Drawing.Size(42, 13);
            this.lb_Termin.TabIndex = 15;
            this.lb_Termin.Text = "Termin:";
            // 
            // tb_DataWystawienia
            // 
            this.tb_DataWystawienia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fVSelectBindingSource, "Data_wystawienia", true));
            this.tb_DataWystawienia.Location = new System.Drawing.Point(58, 174);
            this.tb_DataWystawienia.Name = "tb_DataWystawienia";
            this.tb_DataWystawienia.Size = new System.Drawing.Size(114, 20);
            this.tb_DataWystawienia.TabIndex = 14;
            // 
            // lb_Data
            // 
            this.lb_Data.AutoSize = true;
            this.lb_Data.Location = new System.Drawing.Point(9, 177);
            this.lb_Data.Name = "lb_Data";
            this.lb_Data.Size = new System.Drawing.Size(33, 13);
            this.lb_Data.TabIndex = 13;
            this.lb_Data.Text = "Data:";
            // 
            // btm_DodajDB
            // 
            this.btm_DodajDB.Location = new System.Drawing.Point(454, 228);
            this.btm_DodajDB.Name = "btm_DodajDB";
            this.btm_DodajDB.Size = new System.Drawing.Size(75, 23);
            this.btm_DodajDB.TabIndex = 12;
            this.btm_DodajDB.Text = "Dodaj";
            this.btm_DodajDB.UseVisualStyleBackColor = true;
            this.btm_DodajDB.Click += new System.EventHandler(this.btm_DodajDB_Click);
            // 
            // tb_Miasto
            // 
            this.tb_Miasto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fVSelectBindingSource, "Miasto", true));
            this.tb_Miasto.Location = new System.Drawing.Point(216, 136);
            this.tb_Miasto.Name = "tb_Miasto";
            this.tb_Miasto.Size = new System.Drawing.Size(323, 20);
            this.tb_Miasto.TabIndex = 11;
            // 
            // lb_Miasto
            // 
            this.lb_Miasto.AutoSize = true;
            this.lb_Miasto.Location = new System.Drawing.Point(166, 139);
            this.lb_Miasto.Name = "lb_Miasto";
            this.lb_Miasto.Size = new System.Drawing.Size(41, 13);
            this.lb_Miasto.TabIndex = 10;
            this.lb_Miasto.Text = "Miasto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kod:";
            // 
            // tb_Kod
            // 
            this.tb_Kod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fVSelectBindingSource, "Kod", true));
            this.tb_Kod.Location = new System.Drawing.Point(58, 136);
            this.tb_Kod.MaxLength = 10;
            this.tb_Kod.Name = "tb_Kod";
            this.tb_Kod.Size = new System.Drawing.Size(87, 20);
            this.tb_Kod.TabIndex = 8;
            // 
            // tb_NrDom
            // 
            this.tb_NrDom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fVSelectBindingSource, "Nr_dom_lokal", true));
            this.tb_NrDom.Location = new System.Drawing.Point(397, 102);
            this.tb_NrDom.MaxLength = 10;
            this.tb_NrDom.Name = "tb_NrDom";
            this.tb_NrDom.Size = new System.Drawing.Size(142, 20);
            this.tb_NrDom.TabIndex = 7;
            // 
            // lb_NrDom
            // 
            this.lb_NrDom.AutoSize = true;
            this.lb_NrDom.Location = new System.Drawing.Point(311, 105);
            this.lb_NrDom.Name = "lb_NrDom";
            this.lb_NrDom.Size = new System.Drawing.Size(80, 13);
            this.lb_NrDom.TabIndex = 6;
            this.lb_NrDom.Text = "Nr. dom/lokalu:";
            // 
            // tb_Ulica
            // 
            this.tb_Ulica.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fVSelectBindingSource, "Ulica", true));
            this.tb_Ulica.Location = new System.Drawing.Point(58, 102);
            this.tb_Ulica.Name = "tb_Ulica";
            this.tb_Ulica.Size = new System.Drawing.Size(233, 20);
            this.tb_Ulica.TabIndex = 5;
            // 
            // lb_Ulica
            // 
            this.lb_Ulica.AutoSize = true;
            this.lb_Ulica.Location = new System.Drawing.Point(9, 105);
            this.lb_Ulica.Name = "lb_Ulica";
            this.lb_Ulica.Size = new System.Drawing.Size(34, 13);
            this.lb_Ulica.TabIndex = 4;
            this.lb_Ulica.Text = "Ulica:";
            // 
            // tb
            // 
            this.tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fVSelectBindingSource, "NIP", true));
            this.tb.Location = new System.Drawing.Point(58, 28);
            this.tb.MaxLength = 10;
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(87, 20);
            this.tb.TabIndex = 3;
            // 
            // lb_NIP
            // 
            this.lb_NIP.AutoSize = true;
            this.lb_NIP.Location = new System.Drawing.Point(9, 31);
            this.lb_NIP.Name = "lb_NIP";
            this.lb_NIP.Size = new System.Drawing.Size(28, 13);
            this.lb_NIP.TabIndex = 2;
            this.lb_NIP.Text = "NIP:";
            // 
            // tb_Nazwa
            // 
            this.tb_Nazwa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fVSelectBindingSource, "Sprzedawca", true));
            this.tb_Nazwa.Location = new System.Drawing.Point(58, 63);
            this.tb_Nazwa.Name = "tb_Nazwa";
            this.tb_Nazwa.Size = new System.Drawing.Size(481, 20);
            this.tb_Nazwa.TabIndex = 1;
            // 
            // lb_Nazwa
            // 
            this.lb_Nazwa.AutoSize = true;
            this.lb_Nazwa.Location = new System.Drawing.Point(9, 66);
            this.lb_Nazwa.Name = "lb_Nazwa";
            this.lb_Nazwa.Size = new System.Drawing.Size(43, 13);
            this.lb_Nazwa.TabIndex = 0;
            this.lb_Nazwa.Text = "Nazwa:";
            // 
            // fVSelectTableAdapter
            // 
            this.fVSelectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FVSelectTableAdapter = this.fVSelectTableAdapter;
            this.tableAdapterManager.UpdateOrder = Projekt_VN.DBProjekt_VNDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 461);
            this.Controls.Add(this.gb_Pola);
            this.Controls.Add(this.gb_Glowne);
            this.Controls.Add(this.ts_FInfo);
            this.Controls.Add(this.ms_FMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.ms_FMenu;
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OCR VN - Wersja 1.5.2 Dev";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.ms_FMenu.ResumeLayout(false);
            this.ms_FMenu.PerformLayout();
            this.ts_FInfo.ResumeLayout(false);
            this.ts_FInfo.PerformLayout();
            this.gb_Glowne.ResumeLayout(false);
            this.gb_Glowne.PerformLayout();
            this.gb_Pola.ResumeLayout(false);
            this.gb_Pola.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fVSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProjekt_VNDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_FMenu;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ts_FInfo;
        private System.Windows.Forms.ToolStripLabel tsl_UserLogon;
        private System.Windows.Forms.ToolStripMenuItem funkcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czynnościAdmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAplikacjiToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfd_Text;
        private System.Windows.Forms.Button btm_Scannow;
        private System.Windows.Forms.OpenFileDialog ofs_Ocr;
        private System.Windows.Forms.Button btm_Preprocess;
        private System.Windows.Forms.GroupBox gb_Glowne;
        private System.Windows.Forms.GroupBox gb_Pola;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label lb_NIP;
        private System.Windows.Forms.TextBox tb_Nazwa;
        private System.Windows.Forms.Label lb_Nazwa;
        private System.Windows.Forms.Label lb_Ulica;
        private System.Windows.Forms.TextBox tb_NrDom;
        private System.Windows.Forms.Label lb_NrDom;
        private System.Windows.Forms.TextBox tb_Ulica;
        private System.Windows.Forms.Button btm_DodajDB;
        private System.Windows.Forms.TextBox tb_Miasto;
        private System.Windows.Forms.Label lb_Miasto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Kod;
        private System.Windows.Forms.Label lb_Data;
        private System.Windows.Forms.TextBox tb_TerminPlatnosci;
        private System.Windows.Forms.Label lb_Termin;
        private System.Windows.Forms.TextBox tb_DataWystawienia;
        private System.Windows.Forms.TextBox tb_Vat;
        private System.Windows.Forms.Label lb_Vat;
        private System.Windows.Forms.TextBox tb_Kwota;
        private System.Windows.Forms.Label lb_Kwota;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private DBProjekt_VNDataSet dBProjekt_VNDataSet;
        private System.Windows.Forms.BindingSource fVSelectBindingSource;
        private DBProjekt_VNDataSetTableAdapters.FVSelectTableAdapter fVSelectTableAdapter;
        private DBProjekt_VNDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Label lb_Kolejnoscdzialan;
        private System.Windows.Forms.ToolStripMenuItem bazaDanychToolStripMenuItem;
    }
}

