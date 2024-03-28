using EmployeesApplication.Domain.Enums;
using EmployeesApplication.Domain.Models;

/*Employees employee = new Employees();

Employees secondEmployee = new Employees("Kate", "Katesky", 1000, EmployeeRole.Manager);
secondEmployee.PrintInfo();

double secondEmployeeSalary = secondEmployee.GetSalary();

Manager manager = new Manager("Paul", "Paulsky", 1000);
manager.AddBonus(200);

double managerSalary = manager.GetSalary();*/


Manager manager1 = new("Bob", "Bobert", 2000);
Manager manager2 = new("Rick", "Rickert", 2500);

Contractor contractor1 = new("Mona", "Monalisa", 10, 40, 20, manager1);
Contractor contractor2 = new("Igor", "Igorsky", 8, 30, 25, manager2);

SalesPerson salesPerson = new("Lea", "Leova", 3000);

List<Employees> company = new() { salesPerson, manager1, manager2, contractor1, contractor2 };

CEO ceoName = new("Ron", "Ronsky", 4500, 1000, company);
ceoName.AddSharesPrice(1.2);
Console.WriteLine("CEO:");
ceoName.PrintInfo();
Console.WriteLine($"Salary of CEO is: {ceoName.GetSalary()}");
ceoName.PrintEmployees();




