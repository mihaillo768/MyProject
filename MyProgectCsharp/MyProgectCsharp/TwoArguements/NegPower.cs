using System;

namespace MyProjectCsharp.TwoArguements
{
    public class NegPower:ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Деление на ноль запрещено");
            }
            return Math.Pow(first, 1/second);
        }
    }
}
