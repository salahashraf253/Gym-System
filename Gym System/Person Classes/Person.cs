using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_System.Person_Classes
{
    internal class Person
    {
        protected int id;
        protected string firstName;
        protected string lastName;
        protected string email;
        protected string password;
        protected string type;
        protected float weight;
        public Person(int id,string firstName,string lastName,string email,string password,string type, float weight)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.type = type;
            this.weight = weight;
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

        //password
        public string getPassword() 
        { 
            return password; 
        }
        public void setPassword(string password) 
        {
            this.password = password; 
        }
    }
}
