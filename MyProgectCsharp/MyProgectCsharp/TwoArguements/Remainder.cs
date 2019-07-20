namespace MyProjectCsharp.TwoArguements
{
    public class Remainder: ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first % second;
        }
    }
}
