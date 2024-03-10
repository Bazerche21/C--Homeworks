using System;

int[] numbers = new int[6];

Console.WriteLine("Enter 6 numbers: ");

for (int i = 0; i < 6; i++)
{
    Console.Write($"Number {i + 1}: ");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        numbers[i] = number;
    }
    else
    {
        Console.WriteLine("Invalid input! Please enter an integer.");
        i--;
    }

    int sumOfEven = 0;

    foreach(int num in numbers)
    {
        if (num %2 == 0) {

            sumOfEven+= num;
        }
    }

    Console.WriteLine($"Sum of even numbers: {sumOfEven}");
}
