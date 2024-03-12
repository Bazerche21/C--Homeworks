using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Xml.Linq;

public class Dog
{
    String Name { get; set; }
    String Breed { get; set; }
    String Color { get; set; }

    public Dog(String Name, String Breed, String Color)
    {
        this.Name = Name;
        this.Breed = Breed;
        this.Color = Color;
    }

    public Dog() { 
    }

    public String Eat()
    {
        return "The dog is eating";
    }
    public String Play()
    {
        return "The dog is now playing";
    }
    public String ChaseTail()
    {
        return "Dog is now chasing its tail";
    }
    public override string ToString()
    {
        return $"Name: {Name}, Breed: {Breed}, Color: {Color}";
    }

    public static void Main(string[] args)
    {

        Dog myDog = new Dog("Skaj", "Maltese", "White");
        Console.WriteLine(myDog.ToString());

        Console.WriteLine("Choose an option:");
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
                Console.WriteLine("Invalid input. Must be a number (1, 2, or 3).");
                break;
            }
        }
            
    }
}
