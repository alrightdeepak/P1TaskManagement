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
    public class ApiUserService : IUserService
    {
        private readonly HttpClient _httpClient;
        public ApiUserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<UserData> Authenticate(string username, string password)
        {
            var response = await _httpClient.PostAsJsonAsync("api/users/auth", new { username, password });
            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                return null;
            response.EnsureSuccessStatusCode();
            var user= await response.Content.ReadFromJsonAsync<UserData>();
            return user;
        }
        public async Task<bool> Validate(string username)
        {
            var result = await _httpClient.GetFromJsonAsync<bool>($"api/users/validate/{username}");
            return result;
        }
        public async Task ChangePassword(string username, string newPassword)
        {
            await _httpClient.PutAsJsonAsync("api/users/changePassword",new { username, newPassword });
        }
        public async Task<BindingList<UserData>> GetAll(string userType)
        {
            var users = await _httpClient.GetFromJsonAsync<BindingList<UserData>>($"api/users/{userType}");
            return users ?? new BindingList<UserData>();
        }
    }
}
