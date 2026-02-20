using System.ComponentModel;
using TaskManagement.Models;
using TaskManagement.Services.Interfaces;

namespace TaskManagement.Controllers
{
    public class TaskController
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public BindingList<TaskItems> ShowTasks(int userId)
        {
            return _taskService.ShowTasks(userId);
        }
        public int getNextTaskId(int userId)
        {
            return _taskService.getNextTaskId(userId);
        }
        public void AddTask(int userId, string description)
        {
            _taskService.AddTask(userId, description);
        }

        public void RemoveTask(TaskItems task)
        {
            _taskService.RemoveTask(task);
        }

        public void EditTask(int userId, int taskId, string desc, bool status)
        {
            _taskService.EditTask(userId, taskId, desc, status);
        }
    }
}
