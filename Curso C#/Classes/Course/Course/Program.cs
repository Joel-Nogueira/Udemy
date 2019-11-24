using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            double Preco;
            int Quantidade;

            Console.WriteLine("Entre os dados do produto:");
            
            Console.Write("Nome: ");
            
            Nome = Console.ReadLine();
            
            Console.Write("Preço: ");
            
            Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Quantidade no estoque: ");
            
            Quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(Nome, Preco, Quantidade);

            //Produto p2 = new Produto { 
            //    Nome = "Computador",
            //    Preco = 2000,
            //    Quantidade = 10
            //};
            
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            
            int qte = int.Parse(Console.ReadLine());
            
            p.AdicionarProdutos(qte);
            
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            
            qte = int.Parse(Console.ReadLine());
            
            p.RemoverProdutos(qte);
            
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}