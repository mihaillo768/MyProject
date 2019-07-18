using System;

namespace MyProgectCsharp.One_argument
{
    class OneArgumentFactory
    {
        public static IOneArgrumentCalculator CreateCalculator(string operationName)
        {
            switch (operationName)
            {
                case "ArcSinus":
                    return new Arcsin();
                case "Sinus":
                    return new Sinus();
                case "Cosinus":
                    return new Cosinus();
                case "Tangens":
                    return new Tangens();
                case "Catangens":
                    return new Catangens();
                default:
                    throw new Exception("Несуществующая операция");
            }
        }
    }
}
