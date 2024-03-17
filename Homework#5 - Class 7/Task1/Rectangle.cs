using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Task1.Model;

namespace Task1
{
    internal class Rectangle : Shape
    {
        public int sideA;
        public int sideB;
        
        public Rectangle(string name, string color, int[] position, int sideA, int sideB)
        : base(name, color, position)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }
        public int SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }
        public int SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }

        public override void getArea()
        {
            Console.WriteLine($"Area of the rectangle: {sideA * sideB}");
        }
        public override void getPerimeter()
        {
            Console.WriteLine($"Perimeter of the rectangle: {2 * (sideA + sideB)}");
        }
    }
}
