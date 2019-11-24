using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {

            //PROBLEMA 1: ALTURA MÉDIA
            Console.Write("Insira a quantidade de pessoas: ");
            int qtd = int.Parse(Console.ReadLine());

            double[] altura = new double[qtd];
            double soma = 0.0, 
                   media = 0.0;

            for (int i = 0; i < altura.Length; i++) 
            {
                Console.Write("\nInsira a altura " + (i + 1) + ": ");
                altura[i] = double.Parse(Console.ReadLine());
                soma = soma + altura[i];
            }

            media = soma / altura.Length;

            Console.WriteLine("\nA altura média é: " + media.ToString("F2"));

            //PROBLEMA 2: 
            Console.Write("\nInsira a quantidade de produtos: ");
            qtd = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[qtd];

            for (int i = 0; i < produtos.Length; i++)
            {
                Console.Write("\nInsira o nome do produto: ");
                produtos[i].Nome = Console.ReadLine();

                Console.Write("\nInsira o preço do produto: ");
                produtos[i].Preco = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < produtos.Length; i++)
                Console.WriteLine(produtos[i].ToString());
        }
    }
}
