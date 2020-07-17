using Projekt_VN.Models;

namespace Projekt_VN.Mappers
{
    public class UserAuthenticationMapper
    {
        public static UserAuthentication Map(string login, string password)
        {
            return new UserAuthentication()
            {
                Login = login,
                Password = password
            };
        }
    }
}
