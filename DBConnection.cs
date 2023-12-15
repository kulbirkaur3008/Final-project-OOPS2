using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace MauiApp1.Data
{
    public class DBConnection
    {
        MySqlConnection _connection;
        public DBConnection()
        {
            ConnectToDatabase();
        }
        private void ConnectToDatabase()
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server="localhost",
                UserID="root",
                Password="password",
                Database= "gym_management"
            };

            _connection = new MySqlConnection(builder.ConnectionString);
        }

        public void Execute(string mysql)
        {
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(mysql, _connection);
            cmd.ExecuteNonQuery();
            _connection.Close();
        }
    }
    
}
