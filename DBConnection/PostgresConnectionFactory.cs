using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Configuration;

namespace TaskManagement.DBConnection
{
    public class PostgresConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;

        public PostgresConnectionFactory(IConfiguration configuration)
        {
            _connectionString =configuration.GetConnectionString("Postgres");
        }

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }
    }
}

