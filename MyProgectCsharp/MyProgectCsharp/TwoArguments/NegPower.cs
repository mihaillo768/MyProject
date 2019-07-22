using System;

namespace MyProjectCsharp.TwoArguments
{
    public class NegPower:ITwoArgumentsCalculator
    {
        /// <summary>
        /// raises a number to a power
        /// </summary>
        /// <param name="first">base</param>
        /// <param name="second">denominator of power</param>
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
