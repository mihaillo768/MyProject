using System;

namespace MyProjectCsharp.OneArgument
{
    public class Tangent : IOneArgumentCalculator
    {
        /// <summary>
        /// computes the tangent of a number
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}
