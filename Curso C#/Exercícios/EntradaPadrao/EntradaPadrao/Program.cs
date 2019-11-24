using System;

namespace EntradaPadrao
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            Console.WriteLine(frase);

            string[] s = frase.Split(' ');

            for (int i = 0; i < s.Length; i++) {
                Console.WriteLine(s[i]);
            }
        }
    }
}
