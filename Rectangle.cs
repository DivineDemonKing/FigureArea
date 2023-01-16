using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Rectangle : Figure
    {
        public Rectangle(double hight, double width)
        {
            A = hight;
            B = width;
            C = hight;
            D = width;
        }
        public override double CalculateArea()
        {
            return A * B;
        }
        public double A { get; set; } //Левая Сторона, Высота
        public double B { get; set; } //Верхняя сторона, Ширина
        public double C { get; set; } //Правая сторона, Высота
        public double D { get; set; } //Нижняя сторона, Ширина
    }
}
