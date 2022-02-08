using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_System.Person_Classes
{
    internal class Trainer : Person
    {
        public Trainer(int id, string firstName, string lastName, string email, string password, string type, float weight) :
            base(id, firstName, lastName, email, type)
        {

        }

    }
}
