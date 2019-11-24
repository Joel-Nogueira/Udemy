using System;

namespace ExercicioMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdNumerosNegativos = 0;

            Console.Write("Insira a dimensão da matriz quadrada: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n,n];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Insira os valores da posição [" + i + ", " + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Valores da diagonal");

            for (int i = 0; i < n; i ++)
                Console.WriteLine("[" + i + ", " + i + "]: " + matriz[i,i]);

            Console.WriteLine("Valores negativos da matriz");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        Console.WriteLine("[" + i + ", " + j + "]: " + matriz[i, j]);
                        qtdNumerosNegativos++;
                    }
                }
            }

            Console.Write("Quantidade de números negativos: " + qtdNumerosNegativos);
        }
    }
}
