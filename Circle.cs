using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Circle : Figure
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            return area;
        }
        public double Radius { get; set; }
        public double Circumference { get; set; }
    }
}
