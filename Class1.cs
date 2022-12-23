namespace FigureArea
{
    public class Class1
    {
        private double CircleArea(Circle circle)
        {
            double area = Math.PI * circle.Radius * circle.Radius;
            return area;
        }
        private double RectangleArea(Triangle triangle)
        {
            double halfPerimeter = (triangle.A + triangle.B + triangle.C) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - triangle.A) * (halfPerimeter - triangle.B) * (halfPerimeter - triangle.C));
            return area;
        }
        private bool IsRightTriangle(Triangle triangle)
        {
            double[] sides = new double[] { triangle.A, triangle.B, triangle.C };
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