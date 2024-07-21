using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Triangle : IFigure
    {
        public Triangle(double a, double b, double c) {
            A = a; B = b; C = c;
            if (!IsExists())
                throw new Exception("Треугольник с такими сторонами не существует");
        }
        public double A;
        public double B;
        public double C;
        public double GetArea()
        {
            double halfPerimeter = Perimeter() / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
            if (area <= 0) { 
                throw new Exception("");
            }
            return Math.Round(area,2);
        }

        public bool IsRectangular()
        {
            var list = new List<Double> { A, B, C };
            var max = list.Max();
            list.Remove(max);

            double sum = 0;
            foreach(var item in list)
            {
                sum += item * item;
            }

            if (max*max==sum)
                return true;
            return false;
        }

        private bool IsExists ()
        {
           if(A+B<=C||B+C<=A||C+A<=B)
                return false;
           return true;
        }
        private double Perimeter()
        {
            return (A + B + C);
        }

    }
}
