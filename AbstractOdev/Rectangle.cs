using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOdev
{
    class Rectangle : Shape
    {
        private double height;
        private double width;
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                width = value;
            }
        }

        public override void CalculateArea()
        {
            Area = height * width;
            Console.WriteLine("Dikdörtgenin alanı = " + Area);
        }

        public override void CalculatePerimeter()
        {
            Perimeter = 2 * (height + width);
            Console.WriteLine("Dikdörtgenin çevresi = " + Perimeter);
        }
        public Rectangle(double h, double w)
        {
            height = h;
            width = w;
        }
    }
}
