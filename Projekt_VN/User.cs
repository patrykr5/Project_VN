using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_VN
{
    static public class User
    {
        static public int ID;
        static public string Login;
        static public string Imie;
        static public string Nazwisko;

        static public List<string> moduleLIst;
        static User()
        {
            moduleLIst = new List<string>();
        }

        static public string LoginL()
        {
            return Login;
        }

        static public string NameLF()
        {
            return Nazwisko + " " + Imie;
        }
    }
}
