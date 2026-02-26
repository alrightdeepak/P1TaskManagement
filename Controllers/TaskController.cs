using System.ComponentModel;
using TaskManagementCore.Models;
using TaskManagementCore.Services.Interfaces;

namespace TaskManagement.Controllers
{
    public class TaskController
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public Task<BindingList<TaskItems>> ShowTasks(int userId)
        {
            return _taskService.ShowTasks(userId);
        }
        public Task<int> getNextTaskId(int userId)
        {
            return _taskService.getNextTaskId(userId);
        }
        public Task AddTask(int userId, string description)
        {
            return _taskService.AddTask(userId, description);
        }

        public Task RemoveTask(TaskItems task)
        {
            return _taskService.RemoveTask(task);
        }

        public Task EditTask(TaskItems task)
        {
            return _taskService.EditTask(task);
        }
    }
}
