using System;

namespace ExercicioFixacaoMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de linhas da matriz: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            Console.WriteLine("Insira os valores da matriz");

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                    matriz[i, j] = int.Parse(values[j]);
            }

            Console.Write("Digite o valor a ser pesquisado na matriz: ");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == valor)
                    {
                        Console.Write("Posição: [" + i + ", " + j + "]\n");

                        Console.Write("Valor em cima: ");
                        if ((i - 1) >= 0)
                        {
                            Console.WriteLine(matriz[i - 1, j]);
                        }
                        else
                        {
                            Console.WriteLine("Não há valor");
                        }

                        Console.Write("Valor à esquerda: ");
                        if ((j - 1) >= 0)
                        {
                            Console.WriteLine(matriz[i, j - 1]);
                        }
                        else
                        {
                            Console.WriteLine("Não há valor");
                        }

                        Console.Write("Valor em baixo: ");
                        if ((i + 1) < m)
                        {
                            Console.WriteLine(matriz[i + 1, j]);
                        }
                        else
                        {
                            Console.WriteLine("Não há valor");
                        }

                        Console.Write("Valor à direita: ");
                        if ((j + 1) < n)
                        {
                            Console.WriteLine(matriz[i, j + 1]);
                        }
                        else
                        {
                            Console.WriteLine("Não há valor");
                        }
                    }
                }
            }
        }
    }
}
