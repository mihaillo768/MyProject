using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgectCsharp
{
    class Cosinus : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
