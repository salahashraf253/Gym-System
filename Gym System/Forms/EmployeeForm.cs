using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Gym_System.DataBase_Connection;
using Gym_System.GYM_classes;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Gym_System.Forms
{
    public partial class EmployeeForm : Form
    {
        //public static DataGridView dataGridView1;


        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void viewMembersInfo_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            DataBaseFunctions dbf = new DataBaseFunctions();
            dataGridView1.DataSource = dbf.viewMembersUnderCondition(" ");
            dataGridView1.Visible = true;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewMembersWithClass_Click_1(object sender, EventArgs e)
        {
            Functions.viewMembersWithSpecificClass();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            Functions.viewLoginPage();
            Close();
        }
    }
}
