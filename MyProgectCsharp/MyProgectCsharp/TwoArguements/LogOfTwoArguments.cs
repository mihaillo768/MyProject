using System;

namespace MyProjectCsharp.TwoArguements
{
    public class LogOfTwoArguments : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            if (first <= 0 || second <= 0)
            {
                throw new Exception("Основание или аргумент меньше нуля");
            }
            return Math.Log(first, second);
        }
    }
}
