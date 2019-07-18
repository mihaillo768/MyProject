using System;

namespace MyProgectCsharp.One_argument
{
    public class Arcsin : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Asin(first);
        }
    }
}
