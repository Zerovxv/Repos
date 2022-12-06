using Microsoft.Data.SqlClient;



namespace PRSLibrary
{
    public class Connection
    {
        private string connectionString = @"server=localhost\sqlexpress;" +
             "database=PRSDataBase;trusted_connection=true;" +
             "trustServerCertificate=true;";

        public SqlConnection? connection { get; set; } = null;

        public void SelectSQl(string sql) { 
            sql = "SELECT * from Users;";
            SqlCommand sqlCommand = new(sql, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read()) 
            {
                int id = Convert.ToString(reader["Id"]);
                string? username = Convert.ToString(reader)["username"]);








            }
        }
        public void Connect() {
            if(connection is not null) { System.Diagnostics.Debug.WriteLine("Connection already exists!");
                return;
            }
            connection = new SqlConnection(connectionString);
            connection.Open();
            if(connection.State != System.Data.ConnectionState.Open)
            {
                throw new Exception("Could not make connection to database!");
            }
            System.Diagnostics.Debug.WriteLine("Connectin opened sucessfully!");
        }
        public void Disconnect()
        {
            if(connection is not null)
            {
                connection.Close();
                connection = null;
            }

        }

    }
}