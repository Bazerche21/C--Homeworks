using EmployeesApplication.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApplication.Domain.Models
{
    public class Contractor : Employees
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor(string firstName, string lastName, double salary, double workHours, int payPerHours, Manager responsible)
            : base(firstName, lastName, salary, EmployeeRole.Contractor)
        {
            WorkHours = workHours;
            PayPerHour = payPerHours; 
            Responsible = responsible;
        }

        public override double GetSalary()
        {
            double salary = WorkHours * PayPerHour;
            Salary = salary;
            return salary;
        }

        public string CurrentPosition()
        {
            if (Responsible != null && Responsible.Role == EmployeeRole.Manager)
            {
                return "Department: " + Responsible.FirstName;
            }
            else
            {
                return "No responsible manager assigned";
            }
        }
    }
 }

