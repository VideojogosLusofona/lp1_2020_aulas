using System;

namespace MyGenericClass
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Guarda3<string> g3s = new Guarda3<string>();
            Guarda3<float> g3f = new Guarda3<float>();

            g3s.SetItem(0, "Olá");
            g3s.SetItem(2, "Adeus");

            g3f.SetItem(2, 54.6f);

            Console.WriteLine("Strings");
            Console.WriteLine($"\t{g3s.GetItem(0)}");
            Console.WriteLine($"\t{g3s.GetItem(1)}");
            Console.WriteLine($"\t{g3s.GetItem(2)}");

            Console.WriteLine("Floats");
            Console.WriteLine($"\t{g3f.GetItem(0)}");
            Console.WriteLine($"\t{g3f.GetItem(1)}");
            Console.WriteLine($"\t{g3f.GetItem(2)}");
        }
    }
}
