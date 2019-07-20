using System;

namespace MyProjectCsharp.TwoArguements
{
    public class TwoArgumentsPower : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, second);
        }
    }
}
