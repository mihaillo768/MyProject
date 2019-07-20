using System;

namespace MyProjectCsharp.OneArguement
{
    class Power : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}
