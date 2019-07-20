using System;

namespace MyProjectCsharp.TwoArguements
{
    public class MaxNumber: ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
           return Math.Max(first, second);
        }
    }
}
