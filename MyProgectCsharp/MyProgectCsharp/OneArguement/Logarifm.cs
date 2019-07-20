using System;

namespace MyProjectCsharp.OneArguement
{
    class Logarifm : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}
