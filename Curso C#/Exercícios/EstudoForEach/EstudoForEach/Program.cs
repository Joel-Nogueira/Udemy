using System;

namespace EstudoForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[] {"Joel", " Nogueira", " de", " Abreu", " Graça"};
            
            /*nomes[0] = "Joel";
            nomes[1] = "Nogueira";
            nomes[2] = "Abreu";
            nomes[3] = "Graça";*/

            foreach (string str in nomes)
            {
                Console.Write(str);
            }
        }
    }
}
