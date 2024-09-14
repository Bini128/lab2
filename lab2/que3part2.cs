using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
   
        public partial class Person
        {
            public void DisplayInfo()
            {
                Console.WriteLine($"Full Name: {GetFullName()}");
            }

            public void SetNames(string firstName, string lastName)
            {
                this.firstName = firstName;
                this.lastName = lastName;
            }
        }
    
}

