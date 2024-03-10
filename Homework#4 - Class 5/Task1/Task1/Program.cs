using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Xml.Linq;

public class Dog
{
    String Name { get; set; }
    String Breed { get; set; }
    String Color { get; set; }

    public string ChosenAction { get; set; }

    public Dog(String Name, String Breed, String Color, int ChooseMethod)
    {
        this.Name = Name;
        this.Breed = Breed;
        this.Color = Color;
        if (ChooseMethod == 1)
        {
            ChosenAction = Eat();
        }
        else if (ChooseMethod == 2)
        {
            ChosenAction = Play();
        }
        else if (ChooseMethod == 3)
        {
            ChosenAction = ChaseTail();
        }
        else
        {
            Console.WriteLine("Invalid input, must be a number(1, 2 or 3)");
        }
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
        return $"Name: {Name}, Breed: {Breed}, Color: {Color}, Action: {ChosenAction}";
    }

    public static void Main(string[] args)
    {
        Dog myDog = new Dog("Skaj", "Maltese", "White", 1);

        Console.WriteLine(myDog);
    }
}
