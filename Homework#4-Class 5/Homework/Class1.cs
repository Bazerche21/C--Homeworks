using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        public Dog(string Name, string Breed, string Color)
        {
            this.Name = Name;
            this.Breed = Breed;
            this.Color = Color;
        }

        public string Eat()
        {
            return "The dog is eating";
        }
        public string Play()
        {
            return "The dog is now playing";
        }
        public string ChaseTail()
        {
            return "Dog is now chasing its tail";
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Breed: {Breed}, Color: {Color}");
        }
    }
}
