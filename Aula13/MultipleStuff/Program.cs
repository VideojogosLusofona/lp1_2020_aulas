using System;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperList myList = new SuperList()
            { 10.5, -1.5, 2.3, 40.9, 0.0 };
            double min, max;

            myList.GetMinMax1(out min, out max);
            Console.WriteLine($"Min = {min} | Max = {max}");

            SuperList.MinMax mm = myList.GetMinMax2();
            Console.WriteLine($"Min = {mm.Min} | Max = {mm.Max}");

            Tuple<double, double> tp = myList.GetMinMax3();
            Console.WriteLine($"Min = {tp.Item1} | Max = {tp.Item2}");

            (double min, double max) valTp = myList.GetMinMax4();
            Console.WriteLine($"Min = {valTp.min} | Max = {valTp.max}");
        }
    }
}
