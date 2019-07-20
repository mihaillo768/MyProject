using System;

namespace MyProjectCsharp.OneArguement
{
    public class Arccos : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            if (first > 1 || first < -1)
            {
                throw new Exception("Арккоcинус не существует");
            }
            return Math.Acos(first);
        }
    }
}
