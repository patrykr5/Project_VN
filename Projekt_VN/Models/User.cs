using System.Collections.Generic;

namespace Projekt_VN.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> ModuleList { get; set; } = new List<string>();
    }
}
