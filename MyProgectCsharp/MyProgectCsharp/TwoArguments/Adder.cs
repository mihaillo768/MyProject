using MyProjectCsharp.TwoArguments;

namespace MyProjectCsharp.TwoArguments
{
    public class Adder:ITwoArgumentsCalculator
    {
        /// <summary>
        /// adds two numbers
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}
