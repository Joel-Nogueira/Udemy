using System;

namespace AreaDoTriangulo
{
    class Program
    { 
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo(
                    double.Parse(Console.ReadLine()),
                    double.Parse(Console.ReadLine()),
                    double.Parse(Console.ReadLine())
                );

            y = new Triangulo(
                    double.Parse(Console.ReadLine()),
                    double.Parse(Console.ReadLine()),
                    double.Parse(Console.ReadLine())
                );

            Console.WriteLine("Area de X = " + x.GetArea().ToString("F4"));
            Console.WriteLine("Area de Y = " + y.GetArea().ToString("F5"));

            Console.WriteLine(MaiorArea(x.GetArea(), y.GetArea()));
        }

        private static String MaiorArea(double AreaX, double AreaY)
        {
            if (AreaX > AreaY)
            {
                return "Maior área é do triângulo X.";
            }
            else if (AreaX < AreaY)
            {
                return "Maior área é do triângulo Y.";
            }
            else
            {
                return "As áreas são iguais.";
            }
        }
    }
}
