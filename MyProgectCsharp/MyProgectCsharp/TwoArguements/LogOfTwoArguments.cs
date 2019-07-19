using System;

namespace MyProgectCsharp.TwoArguements
{
    public class LogOfTwoArguments:ITwoArgrumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Log(first, second);
        }
    }
}
