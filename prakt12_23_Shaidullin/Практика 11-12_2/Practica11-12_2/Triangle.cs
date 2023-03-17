using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica11_12_2
{
    public class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double h;
        public double x1, x2, x3, y1, y2, y3;
        public void CreateObject()
        {
            Triangle newTriangle = new Triangle();
        }

        public double Area()
        {
            double area = 0.5 * (a * h);
            return area;
        }

        public double Perimeter()
        {
            double perimeter = a + b + c;
            return perimeter;
        }

        public string PointMedian()
        {
            double X = (x1 + x2 + x3) / 3;
            double Y = (y1 + y2 + y3) / 3;
            var result = $"({X};{Y})";
            return result;
        }
    }
}
