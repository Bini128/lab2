using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
   
        public partial class Person
        {
            // Fields
            private string firstName;
            private string lastName;

            // Constructor
            public Person(string firstName, string lastName)
            {
                this.firstName = firstName;
                this.lastName = lastName;
            }

            // Method to get full name
            public string GetFullName()
            {
                return $"{firstName} {lastName}";
            }
        }
    
}
