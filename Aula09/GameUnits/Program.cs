using System;

namespace GameUnits
{
    class Program
    {
        static void Main()
        {
            Unit[] units = new Unit[] {
                new MilitaryUnit(4, 100, 50),
                new SettlerUnit(1, 20) };

            foreach (Unit unit in units)
            {
                Console.WriteLine(unit.ToString());
                unit.Move();
                //Console.WriteLine($"Health = {unit.Health}");
                //Console.WriteLine($"Value  = {unit.Value}");
                Console.WriteLine();
            }

        }
    }
}
