using System;

namespace MyProgectCsharp.One_argument
{
    class Catangens: IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return 1.0/Math.Tan(first);
        }
    }
}
