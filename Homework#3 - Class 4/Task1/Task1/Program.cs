Console.WriteLine("Enter a string:");
string inputString = Console.ReadLine();

if (inputString.Length >= 5)
{
    string lastFiveCharacters = inputString.Substring(inputString.Length - 5);
    Console.WriteLine($"Last 5 characters: {lastFiveCharacters}");
}
else
{
    Console.WriteLine("The string should have at least 5 characters.");
}



