using System;

namespace MyProjectCsharp.TwoArguements
{
    public class Divider:ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Деление на ноль запрещено");
            }
            return first / second;
        }
    }
}
