using System;

namespace MyProgectCsharp.One_argument
{
    class Cosinus : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
