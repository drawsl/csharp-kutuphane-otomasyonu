using Kutuphane_Otomasyonu.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Kutuphane_Otomasyonu.Resources.Classes
{
    public class dbConnection
    {
        string connectionString = "server=localhost;database=library_data;user=root;password=";

        public MySqlConnection connection;

        public dbConnection()
        {
            connection = new MySqlConnection(connectionString);
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine("MySQL Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return dataTable;
        }

        public MySqlConnection OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            return connection;
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }
}
