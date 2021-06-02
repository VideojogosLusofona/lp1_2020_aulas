using System;
using System.Collections.Generic;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        public struct MinMax
        {
            public double Min { get; }
            public double Max { get; }
            public MinMax(double min, double max)
            {
                Min = min;
                Max = max;
            }
        }

        public void GetMinMax1(out double min, out double max)
        {
            min = this[0];
            max = this[0];
            foreach (double d in this)
            {
                if (d < min) min = d;
                else if (d > max) max = d;
            }
        }

        public MinMax GetMinMax2()
        {
            double min = this[0];
            double max = this[0];
            foreach (double d in this)
            {
                if (d < min) min = d;
                else if (d > max) max = d;
            }
            return new MinMax(min, max);
        }

        public Tuple<double, double> GetMinMax3()
        {
            double min = this[0];
            double max = this[0];
            foreach (double d in this)
            {
                if (d < min) min = d;
                else if (d > max) max = d;
            }
            return Tuple.Create(min, max);
        }

        public (double min, double max) GetMinMax4()
        {
            (double min, double max) values = (this[0], this[0]);

            foreach (double d in this)
            {
                if (d < values.min) values.min = d;
                else if (d > values.max) values.max = d;
            }

            return values;
        }
    }
}