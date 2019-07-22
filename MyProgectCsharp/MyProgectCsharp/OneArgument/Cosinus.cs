using System;

namespace MyProjectCsharp.OneArgument
{
    public class Cosinus : IOneArgumentCalculator
    {
        /// <summary>
        /// computes the cosine of a number
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            if (first > 1 || first < -1)
            {
                throw new Exception("Коcинус не существует");
            }
            return Math.Cos(first);
        }
    }
}
