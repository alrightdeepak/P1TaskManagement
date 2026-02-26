using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementCore.Models
{
    public class UserData
    {
        public int userId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string userType { get; set; }
    }
}
