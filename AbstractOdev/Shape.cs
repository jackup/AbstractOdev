using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOdev
{
    public abstract class Shape
    {
        private double area;
        private string color;
        private double perimeter;
        public double Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public double Perimeter
        {
            get
            {
                return perimeter;
            }
            set
            {
                perimeter = value;
            }
        }

        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();
    }
}
