using System;

namespace MyProgectCsharp.TwoArguements
{
    public class TwoArgumentFactory
    {
        public static ITwoArgrumentsCalculator CreateCalculator(string operationName)
        {
            switch(operationName)
            {
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
