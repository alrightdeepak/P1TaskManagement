using System.Net.Http;
using System.Net.Http.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.Json;
using TaskManagementCore.Models;
using TaskManagementCore.Services.Interfaces;
using static System.Net.WebRequestMethods;

namespace TaskManagement.Services
{
    public class ApiTaskService : ITaskService
    {
        private readonly HttpClient _http;
        public ApiTaskService(HttpClient http)
        {
            _http = http;
        }
        public async Task<BindingList<TaskItems>> ShowTasks(int userId)
        {
            var response = await _http.GetAsync($"api/tasks/{userId}");
            var json = await response.Content.ReadAsStringAsync();
            var tasks = JsonSerializer.Deserialize<List<TaskItems>>(
             json,
             new JsonSerializerOptions
             {
                 PropertyNameCaseInsensitive = true
             });
            return new BindingList<TaskItems>(tasks);
        }
        public async Task RemoveTask(TaskItems task)
        {
            var response = await _http.SendAsync(new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri("api/tasks", UriKind.Relative),
                Content = JsonContent.Create(task)
            });
            response.EnsureSuccessStatusCode();
        }
        public async Task EditTask(TaskItems task)
        {
            var response = await _http.PutAsJsonAsync($"api/tasks", task);
            response.EnsureSuccessStatusCode();
        }
        public async Task AddTask(int userId, string description)
        {
            var task = new
            {
                UserId = userId,
                Description = description
            };
            var response = await _http.PostAsJsonAsync($"api/tasks", task);
            response.EnsureSuccessStatusCode();
        }
        public async Task<int> getNextTaskId(int userId)
        {
            var response = await _http.GetFromJsonAsync<int>($"api/tasks/next/{userId}");
            return response;
        }
    }
}
