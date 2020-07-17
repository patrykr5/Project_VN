using Projekt_VN.Controllers;
using Projekt_VN.Enums;
using Projekt_VN.Mappers;
using Projekt_VN.Models;
using System;
using System.Windows.Forms;

namespace Projekt_VN
{
    public partial class Login_Form : Form
    {
        public bool LoginStatus { get; private set; }
        private IAuthentication _authenticationController;

        public Login_Form()
        {
            InitializeComponent();
            _authenticationController = new AuthenticationController();
            LoginStatus = false;
        }

        private void btm_Cancel_Click(object sender, EventArgs e)
        {
            LoginStatus = false;
            Close();
        }

        private void btm_Login_Click(object sender, EventArgs e)
        {
            string login = tb_Login.Text;
            string password = tb_Password.Text;

            if (string.IsNullOrWhiteSpace(login)
                || string.IsNullOrWhiteSpace(password))
            {
                lb_ErrorLogin.Visible = true;
            }
            else
            {
                UserLoginStatus userLoginStatus = _authenticationController.Login(UserAuthenticationMapper.Map(login, password));
                if (userLoginStatus.ErrorId == OperationStatusEnum.Success)
                {
                    _authenticationController.GetUser(userLoginStatus.UserId.Value);
                    LoginStatus = true;
                    Close();
                }
                else
                {
                    LoginStatus = false;
                    lb_ErrorLogin.Visible = true;
                }
            }
        }
    }
}
