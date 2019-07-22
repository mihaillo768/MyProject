using System;
using MyProjectCsharp.OneArgument;

namespace MyProjectCsharp.OneArgument
{
    public class Arccos : IOneArgumentCalculator
    {
        /// <summary>
        /// computes the arccosine of a number
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            if (first > 1 || first < -1)
            {
                throw new Exception("Арккоcинус не существует");
            }
            return Math.Acos(first);
        }
    }
}
