using System;

namespace MyProgectCsharp.OneArguement
{
    class Power: IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}
