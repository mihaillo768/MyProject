using System;

namespace MyProjectCsharp.OneArgument
{
    public class LogarithmOfTwo : IOneArgumentCalculator
    {
        
        public double Calculate(double first)
        {
            return Math.Log(first, 2);
        }
    }
}
