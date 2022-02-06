using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string email= emailTxtBox.Text;
            string password= passwordTxtBox.Text;  
            if(email.Length==0 || password.Length==0)
            {
                MessageBox.Show("Please Enter your email and password","Error");
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
            }
            
        }

        private static Boolean validLogin(string email,string password)
        {
            return false;
        }

    }
}
