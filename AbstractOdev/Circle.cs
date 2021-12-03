using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOdev
{
    class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public override void CalculateArea()
        {
            Area = radius * radius * 3;
            Console.WriteLine("Dairenin alanı = " + Area);
        }

        public override void CalculatePerimeter()
        {
            Perimeter = 2 * 3 * radius;
            Console.WriteLine("Dairenin çevresi = " + Perimeter);
        }
        public Circle(double r)
        {
            radius = r;
        }
    }
}
