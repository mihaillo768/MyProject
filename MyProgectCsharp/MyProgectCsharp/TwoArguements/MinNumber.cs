using System;

namespace MyProjectCsharp.TwoArguements
{
    public class MinNumber:ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Min(first, second);
        }
    }
}
