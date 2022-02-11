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
    public partial class addEditDeleteTrainerForm : Form
    {
        public addEditDeleteTrainerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addTrainerForm addTrainerForm = new addTrainerForm();
            addTrainerForm.Show();
        }
    }
}
