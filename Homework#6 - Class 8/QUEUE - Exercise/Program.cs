var numbers = new Queue<int>();

while (true)
{
    Console.WriteLine("Enter a number: ");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        numbers.Enqueue(number);
    }
    else
    {
        Console.WriteLine("Invalid input! Please enter a valid number.");
        continue;
    }

    char choice;

    do
    {
        Console.Write("Do you want to input another number? (Y/N): ");
        choice = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();
        if (choice != 'Y' && choice != 'N')
        {
            Console.WriteLine("Invalid choice! Please enter 'Y' or 'N'.");
        }
    } while (choice != 'Y' && choice != 'N');

    if (choice == 'N')
    {
        break;
    }
}

Console.WriteLine("Numbers entered:");
foreach (var num in numbers)
{
    Console.WriteLine(num);
}
