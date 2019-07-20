using System;

namespace MyProjectCsharp.OneArguement
{
    public class Arcsin : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            if (first > 1 || first < -1)
            {
                throw new Exception("Арксинус не существует");
            }
            return Math.Asin(first);
        }
    }
}
