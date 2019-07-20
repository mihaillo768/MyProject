using System;

namespace MyProjectCsharp.OneArguement
{
    public class Cosinus : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
