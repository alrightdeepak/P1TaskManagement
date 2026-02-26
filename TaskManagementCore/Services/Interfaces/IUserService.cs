using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using TaskManagementCore.Models;

namespace TaskManagementCore.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserData> Authenticate(string username, string password) ;
        Task<bool> Validate(string username);
        Task ChangePassword(string username, string newPassword);
        Task<BindingList<UserData>> GetAll(string role);
    }
}
