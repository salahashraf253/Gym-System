using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Gym_System.DataBase_Connection
{
    internal class DataBase
    {
        private string connectionString { get; set; }
        private MySqlConnection conn;
        public DataBase()
        {
            this.connectionString = "host = 127.0.0.1;  port = 3306;database=gym_data_base; user = root ; password=1234";
        }

        public MySqlDataReader select(string query)
        {
            conn =new MySqlConnection(connectionString);
            MySqlCommand command=conn.CreateCommand();
            command.CommandText = query;
            try
            {
                conn.Open(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MySqlDataReader reader = command.ExecuteReader();
            
            return reader;
        }
        public DataTable extractData(string query)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(query,connectionString);
            sda.Fill(dt);
            return dt;
        }
        public void deleteData(string query)
        {

        }
        public void insertData(string query)
        {

        }
        public void closeConnection()
        {
            conn.Close();
        }

    }
}

/*string strConnect = " host = 127.0.0.1;  port = 3306;database=gym_data_base; user = root ; password=1234";
MySqlConnection conn = new MySqlConnection(strConnect);
MySqlDataAdapter sda =
    new MySqlDataAdapter("select count(*) from user  where email='" + email + "' and password='" + password + "'", conn);
DataTable dt = new DataTable();
sda.Fill(dt);*/