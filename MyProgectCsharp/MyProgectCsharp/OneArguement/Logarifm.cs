using System;

namespace MyProgectCsharp.OneArguement
{
    class Logarifm: IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}
