using System;

namespace MyProgectCsharp.OneArguement
{
     public class Sinus : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}
