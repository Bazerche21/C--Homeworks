using Homework;

Console.WriteLine("Enter dog's name:");
string name = Console.ReadLine();

Console.WriteLine("Enter dog's breed:");
string breed = Console.ReadLine();

Console.WriteLine("Enter dog's color:");
string color = Console.ReadLine();

Dog myDog = new Dog(name, breed, color);
myDog.PrintInfo();

Console.WriteLine("Choose an option:");
Console.WriteLine("1. Eat");
Console.WriteLine("2. Play");
Console.WriteLine("3. Chase Tail");

if (int.TryParse(Console.ReadLine(), out int choice))
{
    switch (choice)
    {
        case 1:
            Console.WriteLine(myDog.Eat());
            break;
        case 2:
            Console.WriteLine(myDog.Play());
            break;
        case 3:
            Console.WriteLine(myDog.ChaseTail());
            break;
        default:
            Console.WriteLine("Invalid option. Please choose 1, 2, or 3.");
            break;
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid option number.");
}
