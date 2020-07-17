using Projekt_VN.Models;

namespace Projekt_VN.Mappers
{
    public class UserMapper
    {
        public static User Map(int userId, string login, string firstName, string lastName)
        {
            return new User()
            {
                UserId = userId,
                Login = login,
                FirstName = firstName,
                LastName = lastName
            };
        }
    }
}
