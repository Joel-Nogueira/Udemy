using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>() {1, 2, 3, 4, 5};

            /*lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);
            lista.Add(5);*/

            lista.Insert(2, 1000);

            foreach (int num in lista)
            {
                Console.Write(num + ", ");
            }

            Console.WriteLine("\nTamanho da lista: " + lista.Count);

            List<string> nomes = new List<string> { "Joel", "Nogueira"};

            string str = nomes.Find(x => x[3] == 'l');
            string str2 = nomes.Find(Procura);

            int pos = nomes.FindIndex(x => (x.Length > 4) && (x[5] == 'i'));

            Console.WriteLine(str);
            Console.WriteLine(str2);

            Console.WriteLine(pos);

            List<string> l2 = nomes.FindAll(x => x.Length == 8);

            Console.WriteLine(l2[0].ToString());

        }

        static bool Procura(string nome)
        {
            return nome[0] == 'N';
        }
    }
}
