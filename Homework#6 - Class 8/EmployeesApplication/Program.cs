using EmployeesApplication.Domain.Enums;
using EmployeesApplication.Domain.Models;

/*Employees employee = new Employees();

Employees secondEmployee = new Employees("Kate", "Katesky", 1000, EmployeeRole.Manager);
secondEmployee.PrintInfo();

double secondEmployeeSalary = secondEmployee.GetSalary();

Manager manager = new Manager("Paul", "Paulsky", 1000);
manager.AddBonus(200);

double managerSalary = manager.GetSalary();*/


Manager manager1 = new Manager("Bob", "Bobert", 2000);
Manager manager2 = new Manager("Rick", "Rickert", 2500);

Contractor contractor1 = new Contractor("Mona", "Monalisa", 10, 40, 20, manager1);
Contractor contractor2 = new Contractor("Igor", "Igorsky", 8, 30, 25, manager2);

SalesPerson salesPerson = new SalesPerson("Lea", "Leova", 3000);


CEO ceoName = new CEO("Ron", "Ronsky", 4500, 1000);

ceoName.AddSharesPrice(1.2);
Employees[] company = new Employees[] { contractor1, contractor2, manager1, manager2, salesPerson };
Console.WriteLine("CEO:");
ceoName.PrintInfo();
Console.WriteLine($"Salary of CEO is: {ceoName.GetSalary()}");
ceoName.PrintEmployees();

Console.WriteLine("\nCompany:");
foreach (var employee in company)
{
    Console.WriteLine($"{employee.FirstName} {employee.LastName}");
}



