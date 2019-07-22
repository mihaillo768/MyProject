using System;

namespace MyProjectCsharp.TwoArguments
{
    public class Divider : ITwoArgumentsCalculator
    {
        /// <summary>
        /// divides one number by another
        /// </summary>
        /// <param name="first">dividend</param>
        /// <param name="second">divider</param>
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
