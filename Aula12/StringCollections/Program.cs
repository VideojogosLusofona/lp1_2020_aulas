using System;
using System.Collections.Generic;

namespace StringCollections
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string[] variasStrings = { "uma", "duas", "tres", "tres", "quatro"};

            List<string> list = new List<string>();
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>();
            HashSet<string> set = new HashSet<string>();

            IEnumerable<string>[] collections = { list, stack, queue, set };

            foreach (string s in variasStrings)
            {
                list.Add(s);
                stack.Push(s);
                queue.Enqueue(s);
                set.Add(s);
            }

            foreach (IEnumerable<string> collection in collections)
            {
                Console.WriteLine(collection.GetType().Name);
                foreach (string s in collection)
                {
                    Console.WriteLine($"\t{s}");
                }
            }
        }
    }
}
