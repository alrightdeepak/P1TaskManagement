using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TaskManagementAPI.DBConnection;
using TaskManagementCore.Models;
using TaskManagementCore.Services.Interfaces;

namespace TaskManagementAPI.Services.Implementation
{
    public class TaskService : ITaskService
    {
        private readonly DatabaseExecutor _db;

        public TaskService(DatabaseExecutor db)
        {
            _db = db;
        }

        public async Task<BindingList<TaskItems>> ShowTasks(int userId)
        {
            BindingList<TaskItems> tasks = new();

            await _db.ExecuteReaderAsync("SELECT * FROM showTasks_func(@userid)",
                cmd => { cmd.Parameters.AddWithValue("@userid", userId); },
                reader => {
                    while (reader.Read())
                    {
                        tasks.Add(new TaskItems
                        {
                            userId = userId,
                            TaskID = reader.GetInt32(0),
                            Description = reader.GetString(1),
                            Status = reader.GetBoolean(2)
                        });
                    }
                });
            return tasks;
        }
        public async Task<int> getNextTaskId(int userId)
        {
            return await _db.ExecuteScalarAsync<int>("select getNextTaskID_func(@uid)",cmd=>cmd.Parameters.AddWithValue("@uid",userId));
        }

        public async Task EditTask(TaskItems task)
        {
            await _db.ExecuteNonQueryAsync("CALL editTask_SP(@uid, @tid, @desc, @status)",
            cmd =>
            {
                cmd.Parameters.AddWithValue("@uid", task.userId);
                cmd.Parameters.AddWithValue("@tid", task.TaskID);
                cmd.Parameters.AddWithValue("@desc", task.Description);
                cmd.Parameters.AddWithValue("@status", task.Status);
            });
        }

        public async Task AddTask(int userId, string description)
        {
             int nextTaskId = await getNextTaskId(userId);
             await _db.ExecuteNonQueryAsync("CALL addTask_SP(@uid,@tid,@desc)",
             cmd =>
             {
                 
                 cmd.Parameters.AddWithValue("@uid", userId);
                 cmd.Parameters.AddWithValue("@tid", nextTaskId);
                 cmd.Parameters.AddWithValue("@desc", description);
             });
        }

        public async Task RemoveTask(TaskItems task)
        {
            await _db.ExecuteNonQueryAsync("CALL deleteTask_SP(@tid,@uid)",
            cmd =>
            {
                cmd.Parameters.AddWithValue("@tid", task.TaskID);
                cmd.Parameters.AddWithValue("@uid", task.userId);
            });
        }
    }
}