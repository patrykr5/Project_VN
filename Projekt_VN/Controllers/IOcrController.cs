using Projekt_VN.Models;
using System.Collections.Generic;

namespace Projekt_VN.Controllers
{
    public interface IOcrController
    {
        string GetLoginOfLoggedUser();
        PreprocessDataModel PreprocessData(IEnumerable<string> file, string inputText);
    }
}
