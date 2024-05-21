using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TestApp.General;
using TestApp.Models;

namespace TestApp.Services
{
    internal class UserInfoService : IUserInfoService
    {
        private Logger _logger;
        private IUserInfoService _UserService;

        public UserInfoService(Logger logger, IUserInfoService userInfoService) {
            _logger = logger;
            _UserService = userInfoService;
        }

        public bool ValidateUser(UserInfo userInfo)
        {
            _logger.Log($"This Method { nameof(ValidateUser) } is being logged with this details goes here ");

            if (1 = 1)
            {
                return true;
            }
            
            return false;
        }
    }    
}

public interface IUserInfoService
{
    public bool ValidateUser(UserInfo userInfo);
}


public class Caller {

    private IUserInfoService _userService;

    public Caller(IUserInfoService userInfoService) {

        _userService = userInfoService;

    }
    public void VerifyUser() {
        UserInfo userInfo = new UserInfo();
        _userService.ValidateUser(userInfo);
    }

}