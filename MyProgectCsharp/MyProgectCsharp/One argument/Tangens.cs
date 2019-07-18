using System;

namespace MyProgectCsharp.One_argument
{
    class Tangens : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}
