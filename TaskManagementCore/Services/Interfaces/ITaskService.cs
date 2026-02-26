using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using TaskManagementCore.Models;

namespace TaskManagementCore.Services.Interfaces
{
    public interface ITaskService
    {
        Task<BindingList<TaskItems>> ShowTasks(int userId);
        Task<int> getNextTaskId(int userId);
        Task AddTask(int userId, string description);
        Task RemoveTask(TaskItems currTask);
        Task EditTask(TaskItems task);
    }
}
