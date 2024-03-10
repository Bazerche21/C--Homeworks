Console.WriteLine("Welcome to RealCalculator!");


Console.Write("Enter the First number: ");
if (!float.TryParse(Console.ReadLine(), out float num1))
{
    Console.WriteLine("Invalid input! Please enter a valid number.");
    return;
}

Console.Write("Enter the Second number: ");
if (!float.TryParse(Console.ReadLine(), out float num2))
{
    Console.WriteLine("Invalid input! Please enter a valid number.");
    return;
}

Console.Write("Enter the Operation (+, -, *, /): ");
string operation = Console.ReadLine();

float result = 0;

// Using if statements
if (operation == "+")
{
    result = num1 + num2;
}
else if (operation == "-")
{
    result = num1 - num2;
}
else if (operation == "*")
{
    result = num1 * num2;
}
else if (operation == "/")
{
    if (num2 == 0)
    {
        Console.WriteLine("Cannot divide by zero!");
        return;
    }
    result = num1 / num2;
}
else
{
    Console.WriteLine("Invalid operation! Please enter a valid operation (+, -, *, /).");
    return;
}

Console.WriteLine($"The result is: {result}");

// Using switch statement
switch (operation)
{
    case "+":
        result = num1 + num2;
        break;
    case "-":
        result = num1 - num2;
        break;
    case "*":
        result = num1 * num2;
        break;
    case "/":
        if (num2 == 0)
        {
            Console.WriteLine("Cannot divide by zero!");
            return;
        }
        result = num1 / num2;
        break;
    default:
        Console.WriteLine("Invalid operation! Please enter a valid operation (+, -, *, /).");
        return;
}

Console.WriteLine($"The result is: {result}");

