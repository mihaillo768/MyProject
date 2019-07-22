using MyProjectCsharp.TwoArguments;

namespace MyProjectCsharp.TwoArguments
{
    public class Minus: ITwoArgumentsCalculator
    {
        /// <summary>
        /// subtracts numbers
        /// </summary>
        /// <param name="first">minuend</param>
        /// <param name="second">subtrahend</param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}
