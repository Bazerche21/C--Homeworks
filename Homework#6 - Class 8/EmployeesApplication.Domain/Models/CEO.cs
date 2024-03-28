using EmployeesApplication.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApplication.Domain.Models
{
    public class CEO : Employees
    {
        public List<Employees> Employees { get; set; }
        public int Shares { get; private set; }
        private double SharesPrice{ get; set; }

        public CEO(string firstName, string lastName, double salary, int shares, List<Employees> employees)
            : base(firstName, lastName, salary, EmployeeRole.CEO)
        {
            Shares = shares;
            this.Employees = employees;
        }

        public void AddSharesPrice(double amount)
        {
            SharesPrice = amount;
        }

        public void PrintEmployees()
        {
            Console.WriteLine("Employees:");
            foreach (var employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }

        public override double GetSalary()
        {
            double salary = Salary + Shares * SharesPrice;
            return salary;
        }
    }
}
