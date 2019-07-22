using System;
using MyProjectCsharp.OneArgument;

namespace MyProjectCsharp.OneArgument
{
    public class Arcsin : IOneArgumentCalculator
    {
        /// <summary>
        /// computes the sinus of a number
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            if (first > 1 || first < -1)
            {
                throw new Exception("Арксинус не существует");
            }
            return Math.Asin(first);
        }
    }
}
