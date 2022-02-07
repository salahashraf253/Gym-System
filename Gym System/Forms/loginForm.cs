using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Gym_System.DataBase_Connection;
namespace Gym_System.Forms
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void sign_in_btn_Click(object sender, EventArgs e)
        {
            string email= emailTxtBox.Text;
            string password= passwordTxtBox.Text;  
            if(email.Length==0 || password.Length==0)
            {
                MessageBox.Show("Please Enter your email and password","Error");
                emailTxtBox.Clear();
                passwordTxtBox.Clear();
            }
            else if (validLogin(email, password))
            {
                Menu menu=new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password","Error");
                emailTxtBox.Clear();
                passwordTxtBox.Clear();
            }
            
        }

        private static Boolean validLogin(string email,string password)
        {
            try
            {
               
                DataTable dt = new DataTable();
                DataBase db = new DataBase();
                string query = "select count(*) from user  where email='" + email + "' and password='" + password + "'";
                dt = db.getData(query);
                if(dt.Rows[0][0].ToString() == "1")
                {
                    return true;
                }
                return false;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
            return false;
        }

    }
}
// string strConnect = " host = 127.0.0.1;  port = 3306;database=gym_data_base; user = root ; password=1234";
/*MySqlConnection connection = new MySqlConnection(strConnect);
MySqlCommand cmd = connection.CreateCommand();
MySqlDataReader Reader;
DataTable dt = new DataTable();
cmd.CommandText = "select * from user where email='" + email + "' and password='" + password + "'";
connection.Open();

Reader = cmd.ExecuteReader();
connection.Close();
if (Reader.)
{
    return true;
}
return false;*/