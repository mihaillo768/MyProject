using System;

namespace MyProjectCsharp.OneArgument
{
    public class Power : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}
