using System;

namespace MyProjectCsharp.OneArguement
{
    public class Arctan : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Atan(first);
        }
    }
}
