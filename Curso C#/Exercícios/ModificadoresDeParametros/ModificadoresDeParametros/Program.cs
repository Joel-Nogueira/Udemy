using System;

namespace ModificadoresDeParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            //MODIFICADOR params
            Console.WriteLine(Soma(1, 2, 3, 4, 5));
            Console.WriteLine(Soma(1, 2, 3, 4, 5, 6, 7, 8));

            //MODIFICADOR ref
            int a = 10;
            Referencia(ref a);
            Console.WriteLine(a);

            //MODIFICADOR out
            int b;
            ReferenciaOut(out b);
            Console.WriteLine(b);
        }

        public static int Soma(params int[] numeros)
        {
            int soma = 0;

            for (int i = 0; i < numeros.Length; i++)
                soma += numeros[i];

            return soma;
        }

        public static void Referencia(ref int x)
        {
            x = 3;
        }

        public static void ReferenciaOut(out int y)
        {
            y = 5;
        }

    }
}
