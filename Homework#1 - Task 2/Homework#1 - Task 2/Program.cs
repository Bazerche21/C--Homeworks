
int firstNumber, secondNumber, temp;

Console.WriteLine("Enter first number: ");
firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
secondNumber = Convert.ToInt32(Console.ReadLine());

 temp = firstNumber;
firstNumber = secondNumber;
secondNumber = temp;

Console.WriteLine("After Swapping:");
Console.WriteLine("First Number: " + firstNumber);
Console.WriteLine("Second Number: " + secondNumber);
