List<int> numbers = new List<int> {4, 8, 7, 9, 13, 14, 18, 24, 27, 30};

List<int> squaresOfEvens = numbers.Where(x => x % 2 == 0).Select(x => x * x).ToList();

Console.WriteLine("Original Numbers:");
Console.WriteLine(string.Join(", ", numbers));
Console.WriteLine("\nSquares of Even Numbers:");
Console.WriteLine(string.Join(", ", squaresOfEvens));