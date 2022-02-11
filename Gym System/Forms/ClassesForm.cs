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
        {;
            DataBaseFunctions dbf = new DataBaseFunctions();
            dataGridView1.DataSource = dbf.viewClasses();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string stringThatCarryRowNumber = dataGridView1.CurrentCell.ToString();
            //Rowindex=
            int pos = stringThatCarryRowNumber.IndexOf("Row");
            int row = 0;
            for(int i = pos + 9; true; i++) 
            {
                if (stringThatCarryRowNumber[i] >= '0' && stringThatCarryRowNumber[i] <= '9')
                {
                    row = row *10 + stringThatCarryRowNumber[i]-'0';
                }
                else break;
            }
            string className = dataGridView1.Rows[row].Cells[1].Value.ToString() ;
            //MessageBox.Show(className + " " + className.Length);
            showDataGridView(className);
        }
        private void showDataGridView(string className)
        {
            DataBaseFunctions dataBaseFunctions = new DataBaseFunctions();
            dataGridView2.DataSource = dataBaseFunctions.viewMembersWithSpecificClass(className);
            dataGridView2.Visible = true;
        }
        private void ClassesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
