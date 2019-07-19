using System;

namespace MyProgectCsharp.TwoArguements
{
     public class TwoArgumentsPower:ITwoArgrumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, second);
        }
    }
}
