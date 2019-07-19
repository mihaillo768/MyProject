using System;

namespace MyProgectCsharp.TwoArguements
{
    public class MinNumber:ITwoArgrumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Min(first, second);
        }
    }
}
