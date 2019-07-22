using System;

namespace MyProjectCsharp.TwoArguments
{
    
    public class LogOfTwoArguments : ITwoArgumentsCalculator
    {
        /// <summary>
        /// сalculates the logarithm
        /// </summary>
        /// <param name="first">base of log</param>
        /// <param name="second">log content</param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            if (first <= 0 || second <= 0)
            {
                throw new Exception("Основание или аргумент меньше нуля");
            }
            return Math.Log(first, second);
        }
    }
}
