using Projekt_VN.Enums;
using Projekt_VN.Models;

namespace Projekt_VN.Mappers
{
    public class UserLoginStatusMapper
    {
        public static UserLoginStatus Map(int? userId, int erorrId)
        {
            return new UserLoginStatus
            {
                UserId = userId,
                ErrorId = (OperationStatusEnum)erorrId
            };
        }
    }
}
