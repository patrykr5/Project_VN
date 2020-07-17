using Projekt_VN.Models;

namespace Projekt_VN.Controllers
{
    public interface IAuthentication
    {
        User LoggedUser { get; }
        UserLoginStatus Login(UserAuthentication user);
        void GetUser(int userId);
    }
}
