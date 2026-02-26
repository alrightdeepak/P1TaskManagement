using Npgsql;
using System.ComponentModel;
using TaskManagementAPI.DBConnection;
using TaskManagementCore.Models;
using TaskManagementCore.Services.Interfaces;

public class UserService : IUserService
{
    private readonly DatabaseExecutor _db;

    public UserService(DatabaseExecutor dbExecutor)
    {
        _db = dbExecutor;
    }

    public async Task<UserData> Authenticate(string username, string password)
    {
        UserData user = null;
        await _db.ExecuteReaderAsync("SELECT * FROM authenticate_func(@uname,@pass)",
            cmd =>
            {
                cmd.Parameters.AddWithValue("@uname", username);
                cmd.Parameters.AddWithValue("@pass", password);
            },
            reader =>
            {
                if (reader.Read())
                {
                    user = new UserData
                    {
                        userId = reader.GetInt32(0),
                        username = reader.GetString(1),
                        password = reader.GetString(2),
                        userType = reader.GetString(3)
                    };
                }
            });
        return user;
    }

    public async Task<bool> Validate(string username)
    {
        return await _db.ExecuteScalarAsync<bool>("select validate_func(@uname)", cmd => cmd.Parameters.AddWithValue("@uname", username));
    }

    public async Task ChangePassword(string username, string newPassword)
    {
        await _db.ExecuteNonQueryAsync("CALL changePassword_SP(@username,@newpass)",
            cmd =>
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@newpass", newPassword);
            });
    }

    public async Task<BindingList<UserData>> GetAll(string role)
    {
        BindingList<UserData> users = new();

        await _db.ExecuteReaderAsync("SELECT * FROM getall_func(@utype)", cmd=>cmd.Parameters.AddWithValue("@utype",role),
        reader =>
        {
            while (reader.Read())
            {
                users.Add(new UserData
                {
                    userId = reader.GetInt32(0),
                    username = reader.GetString(1),
                    userType = reader.GetString(2)
                });
            }     
        });
        return users;
    }
}
