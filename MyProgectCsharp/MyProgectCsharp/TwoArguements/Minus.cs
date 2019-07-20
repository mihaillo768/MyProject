namespace MyProjectCsharp.TwoArguements
{
    public class Minus: ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}
