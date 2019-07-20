using System;

namespace MyProjectCsharp.OneArguement
{
    public class Tangens : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}
