namespace MyProjectCsharp.TwoArguements
{
    public class Multiplier : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}
