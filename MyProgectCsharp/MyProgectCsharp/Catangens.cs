using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgectCsharp
{
    class Catangens: IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return 1.0/Math.Tan(first);
        }
    }
}
