using System;
using System.Collections.Generic;

namespace TheyCameBefore
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<int> ints = new List<int>()
            { 3, 5, -2, 10, 11, 200, -1000, 23 };

            foreach (int i in ComesBefore<int>(ints, 0))
            {
                Console.WriteLine(i);
            }

            List<string> strings = new List<string>()
            {
                "C",
                "Olá",
                "Adeus",
                "ZBV",
                "XPTO",
                "Baba"
            };

            foreach (string s in ComesBefore<string>(strings, "CBS"))
            {
                Console.WriteLine(s);
            }
        }

        private static IEnumerable<T> ComesBefore<T>(
            IEnumerable<T> stuff, T limit)
            where T : IComparable<T>
        {
            foreach (T thing in stuff)
            {
                if (thing.CompareTo(limit) < 0)
                    yield return thing;
            }
        }
    }
}
