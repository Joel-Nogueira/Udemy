using System;

namespace EstudoStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;

            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);

            p = new Point();

            Console.WriteLine(p);

            //NULLABLE
            Nullable<double> x = null;
            double? y = null;
        }
    }
}
