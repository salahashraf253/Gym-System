using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_System.Person_Classes
{
    internal class Member : Person
    {
        public enum memberShipType
        {
            term,       // specific period of time 
            open,       // month by month 
            payAsYouGo
        }
        public memberShipType membershipType { get; set; }
        public Member(int id, string firstName, string lastName, string email, string password, string type, float weight , memberShipType membershipType) : base
            (id, firstName, lastName, email,type)
        {
            this.membershipType = membershipType;   
        }
    }
}
