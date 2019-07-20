namespace MyProjectCsharp.TwoArguements
{
    public class Divider:ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first / second;
        }
    }
}
