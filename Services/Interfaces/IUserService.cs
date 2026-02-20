using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using TaskManagement.Models;

namespace TaskManagement.Services.Interfaces
{
    public interface IUserService
    {
        UserData Authenticate(string username, string password) ;
        bool Validate(string username);
        void ChangePassword(string username, string newPassword);
        BindingList<UserData> GetAll(string role);
    }
}
