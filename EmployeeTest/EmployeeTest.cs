using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTest
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {

            decimal yearlySalary = 0;

            Employee employee1 = new Employee("Jaron", "Mitchell", 3000);
            Employee employee2 = new Employee("Monica", "Mitchell", 5000);


            Console.WriteLine("Employee 1 monthly salary after raise " + ( (employee1.MonthlySalary / 10) + employee1.MonthlySalary) * 12);
            Console.Write("Employee 2 monthly salary after raise " + ( (employee2.MonthlySalary / 10) + employee2.MonthlySalary) * 12);
            Console.ReadKey();

        }
    }
}
