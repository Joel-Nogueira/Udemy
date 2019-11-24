using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[2, 2];
            
            matriz[0, 0] = 0;
            matriz[0, 1] = 1.0;
            matriz[1, 0] = 2.0;
            matriz[1, 1] = 3.0;

            for (int i = 0; i < matriz.GetLength(0); i++) 
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + ", ");
                }
            }
        }
    }
}
