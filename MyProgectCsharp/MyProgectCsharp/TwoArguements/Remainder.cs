using System;

namespace MyProjectCsharp.TwoArguements
{
    public class Remainder: ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            if (second <= 0 || second > first)
            {
                throw new Exception("Остатка не существует");
            }
            return first % second;
        }
    }
}
