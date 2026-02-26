using Npgsql;

namespace TaskManagementAPI.DBConnection
{
    public interface IDbConnectionFactory
    {
        NpgsqlConnection GetConnection();
    }
}