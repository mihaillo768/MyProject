using System;

namespace MyProgectCsharp.TwoArguements
{
    public class MaxNumber: ITwoArgrumentsCalculator
    {
        public double Calculate(double first, double second)
        {
           return Math.Max(first, second);
        }
    }
}
