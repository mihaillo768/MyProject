using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgectCsharp.One_argument
{
    public class Arccos : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Acos(first);
        }
    }
}
