using System;

namespace Projekt_VN.Models
{
    public class PreprocessDataModel
    {
        public DateTime DateOfIssueOfDocument { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Tax { get; set; }
        public decimal Cost { get; set; }
    }
}
