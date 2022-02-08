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
        public void insertData(string type, int id, string fName, string lName, string phoneNo, int age, string gender,string membership,float weight)
        {
            conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@fName", fName);
                command.Parameters.AddWithValue("@lName", lName);
                command.Parameters.AddWithValue("@phoneNo", phoneNo);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@weight", 0);
                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@membership", membership);

                command.CommandText = "insert into person(id,firstName,lastName,age,gender,weight,membership,type,phoneNumber)" +
                    " values (@id,@fName,@lName,@age,@gender,@weight,@membership,@type,@phoneNo)";

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show(type+" is succefully added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            conn.Close();   
            
        }
        public void closeConnection()
        {
            conn.Close();
        }

    }
}

