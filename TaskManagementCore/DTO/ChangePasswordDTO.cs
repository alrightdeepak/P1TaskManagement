using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagementCore.DTO
{
    public class ChangePasswordDTO
    {
        public string Username { get; set; }
        public string NewPassword { get; set; }
    }
}
