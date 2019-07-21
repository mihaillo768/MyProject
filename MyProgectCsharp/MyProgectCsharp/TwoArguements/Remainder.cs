using System;

namespace MyProjectCsharp.TwoArguements
{
    public class Remainder: ITwoArgumentsCalculator
    {
        /// <summary>
        /// first window - dividend, second - divider
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            if (second <= 0 || second > first)
            {
                throw new Exception("Остатка не существует");
            }
            return first % second;
        }
    }
}
