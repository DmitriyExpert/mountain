using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class DBConnection
    {
<<<<<<< HEAD
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=123321;database=mountain");
=======
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=123;database=mountain");
>>>>>>> 8e1dbe24d4170ecbc37e7ef464b4889fb7a3e141
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
