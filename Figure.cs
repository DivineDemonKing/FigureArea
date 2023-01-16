using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public abstract class Figure
    {
        //Ввожу абстрактный класс от которогу будет наследоваться любая фигура с 3мя
        //и более сторонами, но что на счёт точки/прямой/линии?
        public double Square { get; set; }
        public double Perimetr { get; set; }
        public int Sides { get; set; }
        public abstract double CalculateArea();
    }
}
