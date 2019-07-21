using System;

namespace MyProjectCsharp.TwoArguements
{
    public class NegPower:ITwoArgumentsCalculator
    {
        /// <summary>
        /// first window - base, second - denominator of power
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
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
