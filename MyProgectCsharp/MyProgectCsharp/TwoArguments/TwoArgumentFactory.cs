using System;

namespace MyProjectCsharp.TwoArguments
{
    /// <summary>
    /// This factory selects a calculator of two argument depending on the button pressed
    /// </summary>
    public class TwoArgumentFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string operationName)
        {
            switch(operationName)
            { 
                case "MinValue":
                    return new MinNumber();
                case "NegPower":
                    return new NegPower();
                case "LogOfTwoArg":
                    return new LogOfTwoArguments();
                case "PowerTwoArguments":
                    return new TwoArgumentsPower();
                case "MaxValue":
                    return new MaxNumber();
                case "Remainder":
                    return new Remainder();
                case "Plus":
                    return new Adder();
                case "Minus":
                    return new Minus();
                case "Multiplier":
                    return new Multiplier();
                case "Divider":
                    return new Divider();
                default:
                    throw new Exception("Несуществующая операция");
            }
        }
    }
}
