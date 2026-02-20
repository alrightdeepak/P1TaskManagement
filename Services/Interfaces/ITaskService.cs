using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using TaskManagement.Models;

namespace TaskManagement.Services.Interfaces
{
    public interface ITaskService
    {
        BindingList<TaskItems> ShowTasks(int userId);
        int getNextTaskId(int userId);
        void AddTask(int userId, string description);
        void RemoveTask(TaskItems currTask);
        void EditTask(int uId, int tId, string newDescription, bool newStatus);
    }
}
