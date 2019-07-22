namespace MyProjectCsharp.TwoArguments
{
    public class Multiplier : ITwoArgumentsCalculator
    {
        /// <summary>
        /// multiplies one number by another
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}
