using System;

namespace ExerciciosClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa A, B;

            A = new Pessoa(Console.ReadLine(),
                           int.Parse(Console.ReadLine()));
            B = new Pessoa(Console.ReadLine(),
                           int.Parse(Console.ReadLine()));

            Console.WriteLine(Pessoa.MaisVelha(A, B));

            Funcionario C, D;

            C = new Funcionario(Console.ReadLine(),
                                double.Parse(Console.ReadLine()));
            D = new Funcionario(Console.ReadLine(),
                                double.Parse(Console.ReadLine()));

            Console.WriteLine("O salário médio é: " + Funcionario.SalarioMedio(C, D));

            Console.WriteLine("Objeto C: " + C.ToString() + " e Objeto D: " + D.ToString());
        }
    }
}
