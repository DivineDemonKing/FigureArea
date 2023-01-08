using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Rectangle : Figure
    {
        public Rectangle(double a, double b, double c, double d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
        public override double CalculateArea()
        {
            if (A == B)
            {
                return A * C;
            }
            else
            {
                return A * B;
            }
        }
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }
    }
}
