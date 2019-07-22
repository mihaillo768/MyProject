using System;

namespace MyProjectCsharp.TwoArguments
{
    public class MinNumber : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculates the minimal number of two
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return Math.Min(first, second);
        }
    }
}
