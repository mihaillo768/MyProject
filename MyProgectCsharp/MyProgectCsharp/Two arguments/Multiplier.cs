namespace MyProgectCsharp.Two_arguments
{
    public class Multiplier : ITwoArgrumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}
