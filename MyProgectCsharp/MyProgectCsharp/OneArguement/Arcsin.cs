using System;

namespace MyProjectCsharp.OneArguement
{
    public class Arcsin : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Asin(first);
        }
    }
}
