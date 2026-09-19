using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrmsProject
{
    class DatabaseConnection
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=MySQL1241!;database=hrms_employee_database");

        //open connection function
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //close connection function
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        //return connection function
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
