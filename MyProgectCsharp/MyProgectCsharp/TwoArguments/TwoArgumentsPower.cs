using System;
using MyProjectCsharp.TwoArguments;

namespace MyProjectCsharp.TwoArguments
{
    public class TwoArgumentsPower : ITwoArgumentsCalculator
    {
        /// <summary>
        /// raises a number to a power
        /// </summary>
        /// <param name="first">base</param>
        /// <param name="second">power</param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, second);
        }
    }
}
