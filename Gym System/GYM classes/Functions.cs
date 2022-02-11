using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym_System.Forms;
namespace Gym_System.GYM_classes
{
    internal class Functions
    {
        public static void viewMembersWithSpecificClass()
        {
            ClassesForm classesForm = new ClassesForm();
            classesForm.Show();
        }
        public static void viewLoginPage()
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
        }
    }
}
