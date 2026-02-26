using Npgsql;
using System;

namespace TaskManagementAPI.DBConnection
{
    public class DatabaseExecutor
    {
        private readonly IDbConnectionFactory _connectionFactory;

        public DatabaseExecutor(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task ExecuteReaderAsync(string query,
            Action<NpgsqlCommand> parameterize,
            Action<NpgsqlDataReader> handleRow)
        {
            await using var conn = _connectionFactory.GetConnection();
            await conn.OpenAsync();

            await using var cmd = new NpgsqlCommand(query, conn);

            parameterize?.Invoke(cmd);

            await using var reader = await cmd.ExecuteReaderAsync();
            handleRow(reader);
        }
        public async Task<T> ExecuteScalarAsync<T>(string query,
            Action<NpgsqlCommand> parameterize)
        {
            await using var conn = _connectionFactory.GetConnection();
            await conn.OpenAsync();

            await using var cmd = new NpgsqlCommand(query, conn);

            parameterize?.Invoke(cmd);

            var result = await cmd.ExecuteScalarAsync();

            return (T)Convert.ChangeType(result, typeof(T));
        }

        public async Task ExecuteNonQueryAsync(string query,
            Action<NpgsqlCommand> parameterize)
        {
            await using var conn = _connectionFactory.GetConnection();
            await conn.OpenAsync();

            await using var cmd = new NpgsqlCommand(query, conn);

            parameterize?.Invoke(cmd);

            await cmd.ExecuteNonQueryAsync();
        }
    }
}
