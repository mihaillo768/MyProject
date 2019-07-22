using System;
using MyProjectCsharp.OneArgument;

namespace MyProjectCsharp.OneArgument
{
    public class Sinus : IOneArgumentCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            if (first > 1 || first < -1)
            {
                throw new Exception("Синус не существует");
            }
            return Math.Sin(first);
        }
    }
}
