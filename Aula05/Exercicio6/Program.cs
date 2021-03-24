using System;

namespace MyTestOfRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            int n, soma = 0;
            Random rnd = new Random();

            Console.Write("Insira nº de dados: ");
            aux = Console.ReadLine();
            n = int.Parse(aux);

            for (int i = 0; i < n; i++)
            {
                int valor = rnd.Next(1, 7);
                Console.WriteLine($"Dado {i} com valor {valor}");
                soma += valor;
            }
            Console.WriteLine($"Soma = {soma}");
        }
    }
}
