Console.WriteLine("Enter a number: ");

if(int.TryParse(Console.ReadLine(), out int number)){
    int[] digits = number.ToString().Select(character => int.Parse(character.ToString())).ToArray();

    int sum = 0;
    foreach (int digit in digits)
    {
        sum += digit;
    }

    Console.WriteLine($"Sum of digits: {sum}");
}
else
{
    Console.WriteLine("Invalid input! Please enter a valid number.");
}
