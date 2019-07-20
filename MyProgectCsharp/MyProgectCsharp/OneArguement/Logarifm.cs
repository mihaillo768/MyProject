using System;

namespace MyProjectCsharp.OneArguement
{
    public class Logarifm : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}
