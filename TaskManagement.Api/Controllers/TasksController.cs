using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using TaskManagementCore.Models;
using TaskManagementCore.DTO;
using TaskManagementCore.Services.Interfaces;
namespace TaskManagementAPI.Controllers
{
    [Route("api/tasks")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;
        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<BindingList<TaskItems>>> ShowTasks(int userId)
        {
            var tasks=await _taskService.ShowTasks(userId);
            return Ok(tasks);
        }

        [HttpGet("next/{userId}")]
        public async Task<ActionResult<int>> getNextTaskId(int userId)
        {
            return Ok(await _taskService.getNextTaskId(userId));
        }

        [HttpPost]
        public async Task<IActionResult> AddTask(AddTaskDTO dto)
        {
            await _taskService.AddTask(dto.UserId, dto.Description);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> EditTask( TaskItems task)
        {
            await _taskService.EditTask(task);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveTask([FromBody] TaskItems task)
        {
            await _taskService.RemoveTask(task);
            return Ok();
        }
    }
}
