using System;

namespace MyProjectCsharp.OneArguement
{
    class LogarifmOfTwo : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first, 2);
        }
    }
}
