using System;

namespace MyProjectCsharp.OneArguement
{
    public class Power : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}
