namespace MyProjectCsharp.TwoArguements
{
    public class Adder:ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}
