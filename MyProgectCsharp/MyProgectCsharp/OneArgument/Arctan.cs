using System;

namespace MyProjectCsharp.OneArgument
{
    public class Arctan : IOneArgumentCalculator
    {
        /// <summary>
        /// computes the arctangent of a number
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Atan(first);
        }
    }
}
