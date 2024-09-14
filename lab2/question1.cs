using System;
namespace lab2
{
    public class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public Employee(string name, string email, decimal salary)
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

    internal class question1
    {
       /* static void Main(string[] args)
        {
            Employee emp = new Employee("Binita", "binitalamichhane@gmail.com", 50000);

            emp.DisplayInfo();
            Console.ReadKey();
            Console.Read();

        }*/
    }
}