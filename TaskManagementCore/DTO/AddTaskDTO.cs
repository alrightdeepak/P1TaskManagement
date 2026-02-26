using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManagementCore.DTO
{
    public class AddTaskDTO
    {
        public int UserId { get; set; }
        public string Description { get; set; }
    }
}
