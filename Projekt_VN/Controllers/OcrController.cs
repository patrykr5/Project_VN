using Projekt_VN.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projekt_VN.Controllers
{
    public class OcrController : IOcrController, IDisposable
    {
        private IAuthentication _authenticationController;

        public OcrController()
        {
            _authenticationController = new AuthenticationController();
        }

        public void Dispose()
        {
            _authenticationController = null;
        }

        public string GetLoginOfLoggedUser()
        {
            return _authenticationController.LoggedUser.Login;
        }

        public PreprocessDataModel PreprocessData(IEnumerable<string> file, string inputText)//string input = "aaaaaaaaaa";
        {
            PreprocessDataModel preprocessDataModel = new PreprocessDataModel();
            try
            {
                //auxiliary variables
                char comma = ',';
                char percent = '%';

                string tax = string.Empty;
                string grossAmount = string.Empty;
                string paymentDate = string.Empty;
                int length = inputText.Length;
                string data = string.Empty;

                foreach (string line in file)
                {
                    if (line.Contains("USD") & line.Contains("Total"))
                    {
                        grossAmount = line;
                    }

                    if (line.Contains(percent))
                    {
                        tax = line;
                    }

                    if (line.Contains("-") & line.Length == length)
                    {
                        data = line;
                    }

                    if (line.Contains("Due date"))
                    {
                        paymentDate = line;
                    }
                }

                string secondAuxiliaryValueOfTax = string.Empty;
                string auxiliaryValueOfTax = string.Empty;

                //separating the tax value from the string
                foreach (char str in tax)
                {
                    if (char.IsDigit(str) || str.Equals(percent))
                    {
                        if (str.Equals(percent))
                        {
                            break;
                        }
                        else
                        {
                            auxiliaryValueOfTax += str.ToString();
                        }
                    }
                    else
                    {
                        secondAuxiliaryValueOfTax += str.ToString();
                    }
                }
                string amountOfTax = "23";
                string destinationTax = auxiliaryValueOfTax.Remove(0, auxiliaryValueOfTax.Length - 2);
                if (destinationTax != amountOfTax)
                {
                    destinationTax = auxiliaryValueOfTax.Remove(0, auxiliaryValueOfTax.Length - 1);
                }
                //auxiliary variables
                string alpha = string.Empty;
                string cost = string.Empty;
                string rawPaymentDate = string.Empty;
                //reading gross value from string
                foreach (char str in grossAmount)
                {
                    if (char.IsDigit(str) || str.Equals(comma))
                    {
                        cost += str.ToString();
                    }
                    else
                    {
                        alpha += str.ToString();
                    }
                }
                //conversion of gross amount into decimal
                decimal decimalOfCost = Convert.ToDecimal(cost.Replace(".", ","));
                //loop searching payment date in string
                foreach (char str in paymentDate)
                {
                    if (char.IsDigit(str))
                    {
                        rawPaymentDate += str.ToString();
                    }
                }
                //value assignment from analize
                DateTime rawDate = Convert.ToDateTime(data);
                preprocessDataModel.DateOfIssueOfDocument = rawDate;
                preprocessDataModel.PaymentDate = rawDate.AddDays(Convert.ToInt32(rawPaymentDate));
                preprocessDataModel.Tax = destinationTax;
                preprocessDataModel.Cost = decimalOfCost;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return preprocessDataModel;
        }
    }
}
