using System;

namespace MyProjectCsharp.TwoArguements
{
    public class Divider:ITwoArgumentsCalculator
    {
        /// <summary>
        /// first window - dividend, second - divider
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Деление на ноль запрещено");
            }
            return first / second;
        }
    }
}
