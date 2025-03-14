using MySql.Data.MySqlClient;
using System.Data;

namespace FreelancePlatform.Models
{
    public class dbConnection : IDisposable
    {
        private readonly MySqlConnection connection;

        public dbConnection()
        {

            string connectionString = "server=localhost;port=3306;uid=root;password=root;database=freelanceplatform";
            connection = new MySqlConnection(connectionString);
        }


        public void Open()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }


        public void Close()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }


        public MySqlConnection Connection => connection;


        public int ExecuteNonQuery(string query, params MySqlParameter[] parameters)
        {
            using (var command = new MySqlCommand(query, connection))
            {
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);
                return command.ExecuteNonQuery();
            }
        }


        public object ExecuteScalar(string query, params MySqlParameter[] parameters)
        {
            using (var command = new MySqlCommand(query, connection))
            {
                if (parameters != null && parameters.Length > 0)
                    command.Parameters.AddRange(parameters);
                return command.ExecuteScalar();
            }
        }


        public MySqlDataReader ExecuteReader(string query, params MySqlParameter[] parameters)
        {
            var command = new MySqlCommand(query, connection);
            if (parameters != null && parameters.Length > 0)
                command.Parameters.AddRange(parameters);

            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }


        public void Dispose()
        {
            connection?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
