using System;

namespace ExercicioFixacaoConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta ContaBancaria;

            string Numero;
            string Titular;
            char Resposta;
            double Dinheiro;

            Console.Write("Informe o número da conta: ");
            Numero = Console.ReadLine();

            Console.Write("Informe o titular da conta: ");
            Titular = Console.ReadLine();

            Console.Write("Algum valor será depositado (S/N)? ");
            Resposta = char.Parse(Console.ReadLine());

            if (char.ToUpper(Resposta) == 'S')
            {
                Console.Write("Informe o valor a ser depositado: ");
                Dinheiro = double.Parse(Console.ReadLine());
                ContaBancaria = new Conta(Numero, Titular, Dinheiro);
            }
            else
            {
                ContaBancaria = new Conta(Numero, Titular);
            }

            while (ContaBancaria.Saldo > 0.0)
            {
                Console.WriteLine(ContaBancaria.ToString());

                Console.Write("Alterar titular: ");
                ContaBancaria.AlterarTitular(
                        Console.ReadLine()
                    );

                Console.Write("Depositar valor: ");
                ContaBancaria.Depositar(
                        double.Parse(Console.ReadLine())
                    );

                Console.Write("Sacar valor: ");
                ContaBancaria.Sacar(
                        double.Parse(Console.ReadLine())
                    );
            }

            Console.WriteLine(ContaBancaria.ToString());
        }
    }
}
