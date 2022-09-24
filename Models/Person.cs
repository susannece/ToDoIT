using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoIT.Models
{
    internal class Person
    {
        private int personId;
        private string firstName;
        private string lastName;
 
        public Person(int id, string firstName, string lastName)
        {
            PersonId = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public int PersonId
        {
            get { return personId; }
            set { personId = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set {
                if (string.IsNullOrEmpty(value) || value.Length < 2)
                {
                    throw new ArgumentNullException("Name must be more than 1 letter.");
                }
                firstName = value; 
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2)
                {
                    throw new ArgumentNullException("Name must be more than 1 letter.");
                }
                lastName = value;
            }
        }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }


    }// End class
}// End namespace
