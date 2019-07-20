using System;

namespace MyProjectCsharp.OneArguement
{
    class OneArgumentFactory
    {
        public static IOneArgrumentCalculator CreateCalculator(string operationName)
        {
            switch (operationName)
            {
                case "Sinus":
                    return new Sinus();
                case "Cosinus":
                    return new Cosinus();
                case "Tangens":
                    return new Tangens();
                case "Catangens":
                    return new Catangens();
                case "ArcSinus":
                    return new Arcsin();
                case "ArcCosinus":
                    return new Arccos();
                case "ArcTangens":
                    return new Arctan();
                case "Power":
                    return new Power();
                case "Logarifm":
                    return new Logarifm();
                case "LogarifmOfTwo":
                    return new LogarifmOfTwo();

                default:
                    throw new Exception("Несуществующая операция");
            }
        }
    }
}
