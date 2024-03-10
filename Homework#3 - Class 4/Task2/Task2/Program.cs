Console.WriteLine("Enter a sentence:");
string inputSentence = Console.ReadLine();

string[] words = inputSentence.Split(" ");

Console.WriteLine("Words in the sentence:");
foreach (string word in words)
{
    Console.WriteLine(word);
}
