using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_System.GYM_classes;
namespace Gym_System.Forms
{
    public partial class AdministratorForm : Form
    {
        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void addTrainerBtn_Click(object sender, EventArgs e)
        {
            addEditDeleteTrainerForm addEditDeleteTrainerForm = new addEditDeleteTrainerForm();
            addEditDeleteTrainerForm.Show();
        }

        private void viewAllMemberInfo_Click(object sender, EventArgs e)
        {
            DataBaseFunctions dbf = new DataBaseFunctions();
            dataGridView1.DataSource = dbf.viewMembersUnderCondition(" ");
        }

        private void viewMembersWithSpecificClass_Click(object sender, EventArgs e)
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
