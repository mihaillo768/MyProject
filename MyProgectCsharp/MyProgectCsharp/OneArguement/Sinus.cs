using System;

namespace MyProgectCsharp.OneArguement
{
    class Sinus : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}
