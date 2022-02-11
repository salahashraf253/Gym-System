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
    public partial class addTrainerForm : Form
    {
        public addTrainerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addTrainerBtn_Click(object sender, EventArgs e)
        {
            if(maleCheckBox.Checked && femaleCheckBox.Checked)
            {
                MessageBox.Show("Please choose one gender only!", "Error");
            }
            else if((!maleCheckBox.Checked && !femaleCheckBox.Checked) || idTxt.Text==null || fNameTxt.Text==null
                || ageTxt.Text==null || phoneNoTxt.Text==null)
            {
                MessageBox.Show("Please fill all the data", "Error");
            }
            int id= Int32.Parse(idTxt.Text);
            string fName = fNameTxt.Text;
            string lName = sNameTxt.Text;
            string type = "trainer";
            int age = Int32.Parse(ageTxt.Text);
            string phoneNo = phoneNoTxt.Text;
            string gender;
            if (maleCheckBox.Checked) gender = "male";
            else gender = "female";
            DataBaseFunctions dataBaseFunctions = new DataBaseFunctions();
            dataBaseFunctions.addPerson(type, id, fName, lName, phoneNo, age, gender);
            this.Close();

        }

        private void addTrainerForm_Load(object sender, EventArgs e)
        {

        }
    }
}