using System;

namespace MyProgectCsharp.OneArguement
{
    class Cosinus : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
