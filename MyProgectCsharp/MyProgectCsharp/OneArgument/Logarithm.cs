using System;

namespace MyProjectCsharp.OneArgument
{
    public class Logarithm : IOneArgumentCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}
