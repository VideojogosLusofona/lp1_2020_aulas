using System;
using System.Collections;
using System.Collections.Generic;

namespace HowManyOfThisType
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Program p = new Program();
            Stack<object> myStack = new Stack<object>();
            int n;

            myStack.Push(2);
            myStack.Push(2.3);
            myStack.Push(12f);
            myStack.Push("ola");
            myStack.Push("adeus");
            myStack.Push("");
            myStack.Push(true);

            n = p.HowManyOfType<string>(myStack);

            Console.WriteLine($"There are {n} strings in my stack");

            n = p.HowManyOfType<bool>(myStack);

            Console.WriteLine($"There are {n} bools in my stack");
        }

        private int HowManyOfType<T>(IEnumerable stuff)
        {
            int count = 0;

            foreach (object o in stuff)
            {
                if (o is T) count++;
            }

            return count;
        }
    }
}
