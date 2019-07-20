using System;

namespace MyProjectCsharp.OneArguement
{
    public class Arccos : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Acos(first);
        }
    }
}
