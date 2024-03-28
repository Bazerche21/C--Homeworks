using EmployeesApplication.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApplication.Domain.Models
{
    public class Employees
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EmployeeRole Role { get; set; }
        protected double Salary { get; set; }

        public Employees() { }

        public Employees(string firstName, string lastName, double salary, EmployeeRole role)
        {

            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }

        public virtual double GetSalary()
        {
            return Salary;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"First Name:{FirstName}, Last Name: {LastName}, Salary: {Salary}");
        }
    }
}

