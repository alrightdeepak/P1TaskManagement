using System.ComponentModel;
using TaskManagementCore.Models;
using TaskManagementCore.Services.Interfaces;

namespace TaskManagement.Controllers
{
    public class LoginController
    {
        private readonly IUserService _userService;
        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        public Task<UserData> Authenticate(string username, string password)
        {
            return _userService.Authenticate(username, password);
        }

        public Task<bool> Validate(string username)
        {
            return _userService.Validate(username);
        }

        public Task ChangePassword(string username, string newPassword)
        {
            return _userService.ChangePassword(username, newPassword);
        }

        public Task<BindingList<UserData>> GetAll(string role)
        {
            return _userService.GetAll(role);
        }
    }
}
