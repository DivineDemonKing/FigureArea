using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Triangle : Figure
    {
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public override double CalculateArea()
        {
            double halfPerimeter = (A + B + C) / 2;
            //Стоит ли округлять значение на данном этапе или это лучше сделать на индивидуально выходе 
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
            return area;
        }
        public bool IsRightTriangle(Triangle triangle)
        {
            double[] sides = new double[] { triangle.A, triangle.B, triangle.C };
            //Сортирую чтобы не делать проверки какая из сторон больше
            Array.Sort(sides);

            if (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
