using System;

namespace MyProjectCsharp.TwoArguements
{
    public class LogOfTwoArguments : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Log(first, second);
        }
    }
}
