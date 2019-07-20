using System;

namespace MyProjectCsharp.OneArguement
{
    public class Cosinus : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            if (first > 1 || first < -1)
            {
                throw new Exception("Коcинус не существует");
            }
            return Math.Cos(first);
        }
    }
}
