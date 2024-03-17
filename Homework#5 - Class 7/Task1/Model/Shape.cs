using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Model
{
    internal class Shape
    {
        public string name;
        public string color;
        public int[] position;

        public Shape(string name, string color, int[] position)
        {
            this.name = name;
            this.color = color;
            this.position = position;
        }

        public string Name
        {
            get { return name; }
            set
            {
                Console.WriteLine($"Setting name to: {value}");
                name = value;
            }
        }

        public string Color
        {
            get { return color; }
            set
            {
                Console.WriteLine($"Setting color to: {value}");
                color = value;
            }
        }
        public int[] Position
        {
            get { return position; }
            set { position = value; }
        }

        public virtual void getArea()
        {
            Console.WriteLine("There is no special implemetation");
        }
        public virtual void getPerimeter()
        {
            Console.WriteLine("There is no special implemetation");
        }
        public static void Move(Shape shape)
        {
            shape.Position[0] += 5;
            shape.Position[1] += 5;
        }
    }
}
