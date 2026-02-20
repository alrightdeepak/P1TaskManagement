using Npgsql;
using System.ComponentModel;
using TaskManagement.DBConnection;
using TaskManagement.Models;
using TaskManagement.Services.Interfaces;

public class UserService : IUserService
{
    private readonly DatabaseExecutor _db;

    public UserService(DatabaseExecutor dbExecutor)
    {
        _db = dbExecutor;
    }

    public UserData Authenticate(string username, string password)
    {
        UserData user = null;
        _db.ExecuteReader("SELECT * FROM authenticate_func(@uname,@pass)",
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

    public bool Validate(string username)
    {
        return _db.ExecuteScalar<bool>("select validate_func(@uname)", cmd => cmd.Parameters.AddWithValue("@uname", username));
    }

    public void ChangePassword(string username, string newPassword)
    {
        _db.ExecuteNonQuery("CALL changePassword_SP(@username,@newpass)",
            cmd =>
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@newpass", newPassword);
            });
    }

    public BindingList<UserData> GetAll(string role)
    {
        BindingList<UserData> users = new();

        _db.ExecuteReader("SELECT * FROM getall_func(@utype)", cmd=>cmd.Parameters.AddWithValue("@utype",role),
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
