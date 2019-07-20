using System;

namespace MyProjectCsharp.OneArguement
{
    class Tangens : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}
