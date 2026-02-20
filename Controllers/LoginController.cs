using System.ComponentModel;
using TaskManagement.Models;
using TaskManagement.Services.Interfaces;

namespace TaskManagement.Controllers
{
    public class LoginController
    {
        private readonly IUserService _userService;
        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        public UserData Authenticate(string username, string password)
        {
            return _userService.Authenticate(username, password);
        }

        public bool Validate(string username)
        {
            return _userService.Validate(username);
        }

        public void ChangePassword(string username, string newPassword)
        {
            _userService.ChangePassword(username, newPassword);
        }

        public BindingList<UserData> GetAll(string role)
        {
            return _userService.GetAll(role);
        }
    }
}
