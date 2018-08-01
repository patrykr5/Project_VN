namespace Projekt_VN
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.lb_Login = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btm_Login = new System.Windows.Forms.Button();
            this.btm_Cancel = new System.Windows.Forms.Button();
            this.pb_Auth = new System.Windows.Forms.PictureBox();
            this.dbProc = new Projekt_VN.DBProjekt_VNDataSetTableAdapters.DBProc();
            this.lb_ErrorLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Auth)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.Location = new System.Drawing.Point(57, 50);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(36, 13);
            this.lb_Login.TabIndex = 0;
            this.lb_Login.Text = "Login:";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(57, 87);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(39, 13);
            this.lb_Password.TabIndex = 1;
            this.lb_Password.Text = "Hasło:";
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(102, 47);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(229, 20);
            this.tb_Login.TabIndex = 2;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(102, 84);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '•';
            this.tb_Password.Size = new System.Drawing.Size(229, 20);
            this.tb_Password.TabIndex = 3;
            // 
            // btm_Login
            // 
            this.btm_Login.Location = new System.Drawing.Point(175, 151);
            this.btm_Login.Name = "btm_Login";
            this.btm_Login.Size = new System.Drawing.Size(75, 23);
            this.btm_Login.TabIndex = 4;
            this.btm_Login.Text = "Zaloguj się";
            this.btm_Login.UseVisualStyleBackColor = true;
            this.btm_Login.Click += new System.EventHandler(this.btm_Login_Click);
            // 
            // btm_Cancel
            // 
            this.btm_Cancel.Location = new System.Drawing.Point(256, 151);
            this.btm_Cancel.Name = "btm_Cancel";
            this.btm_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btm_Cancel.TabIndex = 5;
            this.btm_Cancel.Text = "Anuluj";
            this.btm_Cancel.UseVisualStyleBackColor = true;
            this.btm_Cancel.Click += new System.EventHandler(this.btm_Cancel_Click);
            // 
            // pb_Auth
            // 
            this.pb_Auth.Image = ((System.Drawing.Image)(resources.GetObject("pb_Auth.Image")));
            this.pb_Auth.Location = new System.Drawing.Point(13, 12);
            this.pb_Auth.Name = "pb_Auth";
            this.pb_Auth.Size = new System.Drawing.Size(38, 37);
            this.pb_Auth.TabIndex = 6;
            this.pb_Auth.TabStop = false;
            // 
            // lb_ErrorLogin
            // 
            this.lb_ErrorLogin.AutoSize = true;
            this.lb_ErrorLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_ErrorLogin.Location = new System.Drawing.Point(99, 122);
            this.lb_ErrorLogin.Name = "lb_ErrorLogin";
            this.lb_ErrorLogin.Size = new System.Drawing.Size(144, 13);
            this.lb_ErrorLogin.TabIndex = 7;
            this.lb_ErrorLogin.Text = "Niepoprawny login lub hasło!";
            this.lb_ErrorLogin.Visible = false;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 186);
            this.Controls.Add(this.lb_ErrorLogin);
            this.Controls.Add(this.pb_Auth);
            this.Controls.Add(this.btm_Cancel);
            this.Controls.Add(this.btm_Login);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Login);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pb_Auth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Login;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btm_Login;
        private System.Windows.Forms.Button btm_Cancel;
        private System.Windows.Forms.PictureBox pb_Auth;
        private DBProjekt_VNDataSetTableAdapters.DBProc dbProc;
        private System.Windows.Forms.Label lb_ErrorLogin;
    }
}