using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TaskManagement.DBConnection;
using TaskManagement.Models;
using TaskManagement.Services.Interfaces;

namespace TaskManagement.Services.Implementation
{
    public class TaskService : ITaskService
    {
        private readonly DatabaseExecutor _db;

        public TaskService(DatabaseExecutor db)
        {
            _db = db;
        }

        public BindingList<TaskItems> ShowTasks(int userId)
        {
            BindingList<TaskItems> tasks = new();

            _db.ExecuteReader("SELECT * FROM showTasks_func(@userid)",
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
        public int getNextTaskId(int userId)
        {
            int nextTaskId = _db.ExecuteScalar<int>("select getNextTaskID_func(@uid)",cmd=>cmd.Parameters.AddWithValue("@uid",userId));
            return nextTaskId;
        }

        public void EditTask(int uid, int tid, string desc, bool status)
        {
            _db.ExecuteNonQuery("CALL editTask_SP(@uid, @tid, @desc, @status)",
            cmd =>
            {
                cmd.Parameters.AddWithValue("@uid", uid);
                cmd.Parameters.AddWithValue("@tid", tid);
                cmd.Parameters.AddWithValue("@desc", desc);
                cmd.Parameters.AddWithValue("@status", status);
            });
        }

        public void AddTask(int userId, string description)
        {
             _db.ExecuteNonQuery("CALL addTask_SP(@uid,@tid,@desc)",
             cmd =>
             {
                 int nextTaskId = getNextTaskId(userId);
                 cmd.Parameters.AddWithValue("@uid", userId);
                 cmd.Parameters.AddWithValue("@tid", nextTaskId);
                 cmd.Parameters.AddWithValue("@desc", description);
             });
        }

        public void RemoveTask(TaskItems task)
        {
            _db.ExecuteNonQuery("CALL deleteTask_SP(@tid,@uid)",
            cmd =>
            {
                cmd.Parameters.AddWithValue("@tid", task.TaskID);
                cmd.Parameters.AddWithValue("@uid", task.userId);
            });
        }
    }
}