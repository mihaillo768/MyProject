using System;

namespace MyProjectCsharp.TwoArguements
{
    public class NegPower:ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, 1/second);
        }
    }
}
