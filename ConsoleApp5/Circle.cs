using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Circle: IFigure
    {
        public Circle(double r) {
            if (r <= 0)
                throw new Exception("Круг с таким радиусом не существует");
            R = r;
        }
        public double R;
        public double GetArea()
        {
            return Math.Round(R * R* Math.PI,2);
        }
    }
}
