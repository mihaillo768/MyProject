using System;

namespace MyProgectCsharp.One_argument
{
    class Sinus : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}
