using Projekt_VN.Enums;

namespace Projekt_VN.Models
{
    public class UserLoginStatus
    {
        public int? UserId { get; set; }
        public OperationStatusEnum ErrorId { get; set; }
    }
}
