namespace MyProgectCsharp.TwoArguements
{
    public class Remainder: ITwoArgrumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first % second;
        }
    }
}
