using System;

namespace MyProgectCsharp.OneArguement
{
    public class Arccos : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Acos(first);
        }
    }
}
