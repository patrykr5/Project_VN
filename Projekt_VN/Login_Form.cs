using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_VN
{
    public partial class Login_Form : Form
    {
        public bool login_status = false;

        public Login_Form()
        {
            InitializeComponent();
        }

        private void btm_Cancel_Click(object sender, EventArgs e)
        {
            login_status = false;
            Close();
        }

        private void btm_Login_Click(object sender, EventArgs e)
        {          
            //sprawdza czy oba textboxy są puste lub nie mają spacji
            if (string.IsNullOrWhiteSpace(tb_Login.Text) && string.IsNullOrWhiteSpace(tb_Password.Text))
            {
                lb_ErrorLogin.Visible = true;
            }
            else
            {
                int? UserID, ErrorID;
                string Imie, Nazwisko, Login;
                Imie = Nazwisko = Login = "";
                UserID = ErrorID = -1;
                dbProc.UserLogin(tb_Login.Text, tb_Password.Text, ref UserID, ref ErrorID);
                if (ErrorID == 0)
                {
                    lb_ErrorLogin.Visible = false;
                    User.ID = UserID.Value;
                    dbProc.UserGet(User.ID, ref Imie, ref Nazwisko, ref Login);
                    User.Login = Login;
                    User.Imie = Imie;
                    User.Nazwisko = Nazwisko;
                    login_status = true;
                    this.Close();
                }
                else
                {
                    login_status = false;
                    lb_ErrorLogin.Visible = true;
                }
            }
        }
    }
}
