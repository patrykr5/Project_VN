namespace Projekt_VN
{
    partial class About_Form
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
            this.lb_Info1 = new System.Windows.Forms.Label();
            this.lb_Info2 = new System.Windows.Forms.Label();
            this.gb_About = new System.Windows.Forms.GroupBox();
            this.lb_Autor2 = new System.Windows.Forms.Label();
            this.lb_Autor1 = new System.Windows.Forms.Label();
            this.lb_Autorzy = new System.Windows.Forms.Label();
            this.gb_About.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Info1
            // 
            this.lb_Info1.AutoSize = true;
            this.lb_Info1.Location = new System.Drawing.Point(6, 16);
            this.lb_Info1.Name = "lb_Info1";
            this.lb_Info1.Size = new System.Drawing.Size(103, 13);
            this.lb_Info1.TabIndex = 0;
            this.lb_Info1.Text = "Aplikacja OCR 2018";
            // 
            // lb_Info2
            // 
            this.lb_Info2.AutoSize = true;
            this.lb_Info2.Location = new System.Drawing.Point(7, 33);
            this.lb_Info2.Name = "lb_Info2";
            this.lb_Info2.Size = new System.Drawing.Size(70, 13);
            this.lb_Info2.TabIndex = 1;
            this.lb_Info2.Text = "Wersja: 1.6.0";
            // 
            // gb_About
            // 
            this.gb_About.Controls.Add(this.lb_Autor2);
            this.gb_About.Controls.Add(this.lb_Autor1);
            this.gb_About.Controls.Add(this.lb_Autorzy);
            this.gb_About.Controls.Add(this.lb_Info1);
            this.gb_About.Controls.Add(this.lb_Info2);
            this.gb_About.Location = new System.Drawing.Point(12, 12);
            this.gb_About.Name = "gb_About";
            this.gb_About.Size = new System.Drawing.Size(198, 160);
            this.gb_About.TabIndex = 4;
            this.gb_About.TabStop = false;
            // 
            // lb_Autor2
            // 
            this.lb_Autor2.AutoSize = true;
            this.lb_Autor2.Location = new System.Drawing.Point(16, 112);
            this.lb_Autor2.Name = "lb_Autor2";
            this.lb_Autor2.Size = new System.Drawing.Size(68, 13);
            this.lb_Autor2.TabIndex = 6;
            this.lb_Autor2.Text = "Patryk Rajca";
            // 
            // lb_Autor1
            // 
            this.lb_Autor1.AutoSize = true;
            this.lb_Autor1.Location = new System.Drawing.Point(16, 134);
            this.lb_Autor1.Name = "lb_Autor1";
            this.lb_Autor1.Size = new System.Drawing.Size(110, 13);
            this.lb_Autor1.TabIndex = 5;
            this.lb_Autor1.Text = "Bartosz Lewandowski";
            // 
            // lb_Autorzy
            // 
            this.lb_Autorzy.AutoSize = true;
            this.lb_Autorzy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Autorzy.Location = new System.Drawing.Point(7, 89);
            this.lb_Autorzy.Name = "lb_Autorzy";
            this.lb_Autorzy.Size = new System.Drawing.Size(53, 13);
            this.lb_Autorzy.TabIndex = 4;
            this.lb_Autorzy.Text = "Autorzy:";
            // 
            // About_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 184);
            this.Controls.Add(this.gb_About);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.TopMost = true;
            this.gb_About.ResumeLayout(false);
            this.gb_About.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Info1;
        private System.Windows.Forms.Label lb_Info2;
        private System.Windows.Forms.GroupBox gb_About;
        private System.Windows.Forms.Label lb_Autor2;
        private System.Windows.Forms.Label lb_Autor1;
        private System.Windows.Forms.Label lb_Autorzy;
    }
}