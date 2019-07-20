using System;

namespace MyProjectCsharp.OneArguement
{
    public class Catangens : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return 1.0 / Math.Tan(first);
        }
    }
}
