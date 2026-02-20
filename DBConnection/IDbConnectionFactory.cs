using Npgsql;

namespace TaskManagement.DBConnection
{
    public interface IDbConnectionFactory
    {
        NpgsqlConnection GetConnection();
    }
}