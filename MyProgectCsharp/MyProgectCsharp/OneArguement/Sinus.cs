using System;

namespace MyProjectCsharp.OneArguement
{
    public class Sinus : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}
