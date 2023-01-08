using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public abstract class Figure
    {
        public double Square { get; set; }
        public double Perimetr { get; set; }
        public int Sides { get; set; }
        public abstract double CalculateArea();
    }
}
