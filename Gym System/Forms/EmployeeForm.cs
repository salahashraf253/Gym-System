using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_System.DataBase_Connection;
using Gym_System.GYM_classes;
using MySql.Data.MySqlClient;

namespace Gym_System.Forms
{
    public partial class EmployeeForm : Form
    {
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
            dataGridView1.DataSource = dbf.viewMembersUnderCondition("and firstName='Samaa'");
        }

        private void viewMembersWithClass_Click(object sender, EventArgs e)
        {
            ClassesForm classesForm = new ClassesForm();
            classesForm.Show();
            DataBase db = new DataBase();
            
        }
    }
}
