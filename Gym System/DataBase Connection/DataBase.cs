using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Gym_System.DataBase_Connection
{
    internal class DataBase
    {
        private string connectionString { get; set; }
        public DataBase()
        {
            this.connectionString = "host = 127.0.0.1;  port = 3306;database=gym_data_base; user = root ; password=1234";
        }
        public DataTable getData(string query)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(query,connectionString);
            sda.Fill(dt);
            return dt;
        }
    }
}
/*string strConnect = " host = 127.0.0.1;  port = 3306;database=gym_data_base; user = root ; password=1234";
MySqlConnection conn = new MySqlConnection(strConnect);
MySqlDataAdapter sda =
    new MySqlDataAdapter("select count(*) from user  where email='" + email + "' and password='" + password + "'", conn);
DataTable dt = new DataTable();
sda.Fill(dt);*/