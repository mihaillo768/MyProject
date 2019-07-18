using System;

namespace MyProgectCsharp.OneArguement
{
    public class Arcsin : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Asin(first);
        }
    }
}
