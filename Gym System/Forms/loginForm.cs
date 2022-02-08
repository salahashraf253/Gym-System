using Gym_System.DataBase_Connection;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

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
            string email = emailTxtBox.Text;
            string password = passwordTxtBox.Text;
            if (email.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Please Enter your email and password", "Error");
                clearTextBoxs();
            }
            else
            {
                string type = getType(email, password);
                if (type == "null")
                {
                    MessageBox.Show("Invalid email or password", "Error");
                    clearTextBoxs();
                }
                else openMenu(type);
            }
        }

        private void openMenu(string type)
        {
            if(type == "employee")
            {
                EmployeeForm employeeForm = new EmployeeForm();
                employeeForm.Show();
            }
            else
            {
                AdministratorForm administratorForm = new AdministratorForm();
                administratorForm.Show();
            }
            this.Hide();
        }
        private static string getType(string email, string password)
        {
            string type="null";
            try
            {
                DataBase db = new DataBase();
                string query = "select * from user  where email='" + email + "' and password='" + password + "'";
                MySqlDataReader reader = db.select(query);
                int numberOfRows = 0;
                
                while (reader.Read())
                {
                    type = reader["type"].ToString();
                    numberOfRows++;
                }
                db.closeConnection();
                if (numberOfRows == 1)
                {
                    return type;
                }
                return type;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return type;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)   //used for hiding & showing password
        {
            passwordTxtBox.UseSystemPasswordChar = !passwordTxtBox.UseSystemPasswordChar;
        }
        private void clearTextBoxs()
        {
            emailTxtBox.Clear();
            passwordTxtBox.Clear();
        }
    }
}
