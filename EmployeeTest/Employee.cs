using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTest
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private decimal monthlySalary;


        public Employee(string firstName, string lastName, decimal monthlySalary )
        {

            FirstName = firstName;
            LastName = lastName;
            this.monthlySalary = monthlySalary;

        }

        public decimal MonthlySalary
        {
            get
            {
                return monthlySalary;
            }
            set
            {
                if (value < 0)
                {
                    monthlySalary = value;
                }
            }
        }
    }
}
