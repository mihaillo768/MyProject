using System;

namespace MyProgectCsharp.TwoArguements
{
    public class TwoArgumentFactory
    {
        public static ITwoArgrumentsCalculator CreateCalculator(string operationName)
        {
            switch(operationName)
            {
                case "MinValue":
                    return new MinNumber();
                case "NegPower":
                    return new NegPower();
                case "LogarifmOfTwo":
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
