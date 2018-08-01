using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_VN
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //utworzenie nowego okna i przypisanie do lf
            Login_Form lf = new Login_Form();
            lf.ShowDialog();
            //jesli warunek jest spelniony to pojawia sie glowne okno --- default login_status = 1
            if (lf.login_status == true)
            {
                Application.Run(new Main_Form());
            }
        }
    }
}
