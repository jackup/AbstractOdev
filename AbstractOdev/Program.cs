using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s1 = new Square(5);
            s1.CalculateArea();
            s1.CalculatePerimeter();
            Console.WriteLine();

            Rectangle r1 = new Rectangle(6, 8);
            r1.CalculateArea();
            r1.CalculatePerimeter();
            Console.WriteLine();

            Circle c1 = new Circle(8.5);
            c1.CalculateArea();
            c1.CalculatePerimeter();
        }
    }
}
