using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    
    internal class question2
    {
      
            public string Name { get; set; }
            public string Email { get; set; }
            public decimal Salary { get; set; }
            public question2(string name, string email, decimal salary)
            {
                Name = name;
                Email = email;
                Salary = salary;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Email: {Email}");
                Console.WriteLine($"Salary: {Salary:C}"); 
            }
     

    }
}
