using System;

namespace MyProjectCsharp.TwoArguments
{
    public class Remainder: ITwoArgumentsCalculator
    {
        /// <summary>
        /// calculates the remainder of the division
        /// </summary>
        /// <param name="first">dividend</param>
        /// <param name="second">divider</param>
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
