using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProject
{
    internal struct Interval
    {
        public Interval(int minValue, int maxValue) { Min = minValue; Max = maxValue; }

        public int Get { get { return _random.Next(Min, Max); } }
        public int Min { get; }
        public int Max { get; }
        public int Average { get { return (Max + Min) / 2; } }



        private Random _random = new Random();

        
    }
}
