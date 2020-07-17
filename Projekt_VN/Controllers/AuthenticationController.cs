using Projekt_VN.DBProjekt_VNDataSetTableAdapters;
using Projekt_VN.Mappers;
using Projekt_VN.Models;
using System;

namespace Projekt_VN.Controllers
{
    public class AuthenticationController : IAuthentication, IDisposable
    {
        private DBProc _dBProc;
        public User LoggedUser { get; private set; }

        public AuthenticationController()
        {
            _dBProc = new DBProc();
        }

        public void Dispose()
        {
            _dBProc = null;
        }

        public void GetUser(int userId)
        {
            string firstName = string.Empty;
            string lastName = string.Empty;
            string login = string.Empty;

            _dBProc.UserGet(userId, ref firstName, ref lastName, ref login);
            LoggedUser = UserMapper.Map(userId, login, firstName, lastName);
        }

        public UserLoginStatus Login(UserAuthentication userAuthentication)
        {
            int? userId = -1;
            int? errorId = -1;

            _dBProc.UserLogin(userAuthentication.Login, userAuthentication.Password, ref userId, ref errorId);
            return UserLoginStatusMapper.Map(userId, errorId ?? -1);
        }
    }
}
