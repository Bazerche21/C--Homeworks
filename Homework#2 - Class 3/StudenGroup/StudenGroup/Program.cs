String[] studentsG1 = { "Stefan", "Marija", "Petar", "Ana", "Luka" };
String[] studentsG2 = { "Bojan", "Marija", "Lazar", "Stefanija", "Aleksandar" };

Console.WriteLine("Enter group number (1 or 2):");

if (int.TryParse(Console.ReadLine(), out int groupNumber)){
    if(groupNumber == 1) {
        Console.WriteLine("The Students in G1 are:");
        foreach (string student in studentsG1)
        {
            Console.WriteLine(student);
        }
    }
    else if (groupNumber == 2)
    {
        Console.WriteLine("The Students in G2 are:");
        foreach (string student in studentsG2)
        {
            Console.WriteLine(student);
        }
    }
    else
    {
        Console.WriteLine("Invalid group number. Please enter 1 or 2.");
    }
}
else
{
    Console.WriteLine("Invalid input! Please enter a valid number.");
}

