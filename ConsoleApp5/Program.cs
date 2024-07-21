using System.Linq.Expressions;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input=0;
            Console.WriteLine("Введите тип фигуры: 1-круг, 2-треугольник");
            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Некорректный ввод данных");
            }
            
            if (input == 1) {
                Console.WriteLine("Введите радиус:");
                double r = double.Parse(Console.ReadLine());
                try
                {
                    Console.WriteLine(new Circle(r).GetArea());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
            else if (input == 2) {
                var sideArray = new Double[3];
                for (int i = 0;i<3;i++)
                {
                    Console.WriteLine("Введите сторону " + (i+1)+" :");
                    sideArray[i] = double.Parse(Console.ReadLine());
                }
                try
                {
                    Console.WriteLine(new Triangle(sideArray[0], sideArray[1], sideArray[2]).GetArea());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод данных");
            }

        }
    }
}