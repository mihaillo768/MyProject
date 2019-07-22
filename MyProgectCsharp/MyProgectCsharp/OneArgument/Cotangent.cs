using System;

namespace MyProjectCsharp.OneArgument
{
    public class Cotangent : IOneArgumentCalculator
    {
        /// <summary>
        /// computes the cotangent of a number
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return 1.0 / Math.Tan(first);
        }
    }
}
