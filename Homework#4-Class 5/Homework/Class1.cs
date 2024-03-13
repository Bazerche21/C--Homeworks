using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Dog
    {
        public String Name { get; set; }
        public String Breed { get; set; }
        public String Color { get; set; }

        public Dog(String Name, String Breed, String Color)
        {
            this.Name = Name;
            this.Breed = Breed;
            this.Color = Color;
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
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Breed: {Breed}, Color: {Color}");
        }
    }
}
