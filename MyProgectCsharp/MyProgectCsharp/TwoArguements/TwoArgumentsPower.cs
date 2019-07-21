using System;

namespace MyProjectCsharp.TwoArguements
{
    public class TwoArgumentsPower : ITwoArgumentsCalculator
    {
        /// <summary>
        /// first window - base, second - power
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, second);
        }
    }
}
