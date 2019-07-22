using System;

namespace MyProjectCsharp.TwoArguments
{
    public class MaxNumber: ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculates the maximum number of two
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
           return Math.Max(first, second);
        }
    }
}
