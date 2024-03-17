using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Task1.Model;

namespace Task1
{
    internal class Circle : Shape
    {
        public int radius;

        public Circle(string name, string color, int[] position, int radius)
        : base(name, color, position)
        {
            this.radius = radius;
        }

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public override void getArea()
        {
            Console.WriteLine($"Area of the circle: {Math.PI * radius * radius}");
        }

        public override void getPerimeter()
        {
            Console.WriteLine($"Perimeter of the circle: {2 * Math.PI * radius}");
        }
    }
}
