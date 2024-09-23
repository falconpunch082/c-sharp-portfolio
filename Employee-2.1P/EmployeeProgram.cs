using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class EmployeeProgram
    {
        static void Main(String[] args)
        {
            // New employee
            Console.WriteLine("Meet Stewie!");
            Employee stewie = new Employee("Stewie", 80000);

            // Status check
            Console.WriteLine("Name: " + stewie.getName() + "\nSalary: " + stewie.getSalary());

            // Stewie gets a raise
            Console.WriteLine("Stewie got a raise!");
            stewie.raiseSalary(10);

            // Status check
            Console.WriteLine("Name: " + stewie.getName() + "\nSalary: " + stewie.getSalary());
            Console.WriteLine("With his new salary increase, " + stewie.getName() + " will pay " + stewie.tax().ToString("C") + " in tax.");
        }
    }
}
