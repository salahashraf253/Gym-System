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
namespace Gym_System.Forms
{
    public partial class ClassesForm : Form
    {
        public ClassesForm()
        {
            InitializeComponent();
            viewClasses();
        }

        private void viewClasses()
        {
            DataBase dataBase = new DataBase();
            DataBaseFunctions dbf = new DataBaseFunctions();
            dataGridView1.DataSource = dbf.viewClasses();

        }

    }
}
