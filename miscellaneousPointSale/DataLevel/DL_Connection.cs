using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataLevel
{
    public class DL_Connection
    {
        private MySqlConnection Connection = new MySqlConnection("server=localhost;database=dulceria;" +
            "uid=root;pwd=;integrated security = true");
        ConnectionState state = ConnectionState.Closed;

        public ConnectionState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        public MySqlConnection OpenConnection() {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
                state = Connection.State;
            }
            
            return Connection;
        }

        public MySqlConnection CloseConnection() {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
                state = Connection.State;
            }
            return Connection;
        }

        
    }
}
