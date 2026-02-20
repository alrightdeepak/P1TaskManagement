using Npgsql;
using System;

namespace TaskManagement.DBConnection
{
    public class DatabaseExecutor
    {
        private readonly IDbConnectionFactory _connectionFactory;

        public DatabaseExecutor(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public void ExecuteReader(
            string query,
            Action<NpgsqlCommand> parameterize,
            Action<NpgsqlDataReader> handleRow)
        {
            using var conn = _connectionFactory.GetConnection();
            conn.Open();

            using var cmd = new NpgsqlCommand(query, conn);

            parameterize?.Invoke(cmd);

            using var reader = cmd.ExecuteReader();
            handleRow(reader);
        }
        public T ExecuteScalar<T>(
            string query,
            Action<NpgsqlCommand> parameterize)
        {
            using var conn = _connectionFactory.GetConnection();
            conn.Open();

            using var cmd = new NpgsqlCommand(query, conn);

            parameterize?.Invoke(cmd);

            object result = cmd.ExecuteScalar();

            return (T)Convert.ChangeType(result, typeof(T));
        }

        public void ExecuteNonQuery(
            string query,
            Action<NpgsqlCommand> parameterize)
        {
            using var conn = _connectionFactory.GetConnection();
            conn.Open();

            using var cmd = new NpgsqlCommand(query, conn);

            parameterize?.Invoke(cmd);

            cmd.ExecuteNonQuery();
        }
    }
}
