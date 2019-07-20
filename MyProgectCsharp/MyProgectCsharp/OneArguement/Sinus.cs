using System;

namespace MyProjectCsharp.OneArguement
{
    public class Sinus : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            if (first > 1 || first < -1)
            {
                throw new Exception("Синус не существует");
            }
            return Math.Sin(first);
        }
    }
}
