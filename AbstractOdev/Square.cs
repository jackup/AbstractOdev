using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOdev
{
    class Square : Shape
    {
        private double side;
        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }
        }

        public override void CalculateArea()
        {
            Area = side * side;
            Console.WriteLine("Karenin alanı = " + Area);
        }

        public override void CalculatePerimeter()
        {
            Perimeter = 4 * side;
            Console.WriteLine("Karenin çevresi = " + Perimeter);
        }

        public Square(double s)
        {
            side = s;
        }
    }
}
