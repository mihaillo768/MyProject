namespace MyProgectCsharp.TwoArguements
{
    public class Multiplier : ITwoArgrumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}
