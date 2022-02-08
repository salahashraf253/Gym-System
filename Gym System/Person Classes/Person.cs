using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_System.Person_Classes
{
    internal abstract class Person
    {
        protected int id;
        protected int number { get; set; }
        protected string firstName;
        protected string lastName;
        protected string email;
        protected string type;
        public Person(int id,string firstName,string lastName,string email,string type)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.type = type;
        }

        //id
        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        //first name
        public string getFirstName() 
        { 
            return firstName;
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        //last name
        public string getLastName() 
        { 
            return lastName; 
        }
        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        //email
        public string getEmail()
        {
            return email; 
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
    }
}
