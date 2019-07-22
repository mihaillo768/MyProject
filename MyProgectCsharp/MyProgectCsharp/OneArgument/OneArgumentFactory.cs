using System;
using MyProjectCsharp.OneArgument;
using MyProjectCsharp.OneArgument;

namespace MyProjectCsharp.OneArgument
{
    /// <summary>
    /// This factory selects a calculator of one argument depending on the button pressed
    /// </summary>
    public static class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string operationName)
        {
            switch (operationName)
            {
                case "Sinus":
                    return new Sinus();
                case "Cosinus":
                    return new Cosinus();
                case "Tangens":
                    return new Tangent();
                case "Catangens":
                    return new Cotangent();
                case "ArcSinus":
                    return new Arcsin();
                case "ArcCosinus":
                    return new Arccos();
                case "ArcTangens":
                    return new Arctan();
                case "Power":
                    return new Power();
                case "Logarifm":
                    return new Logarithm();
                case "LogarifmOfTwo":
                    return new LogarithmOfTwo();

                default:
                    throw new Exception("Несуществующая операция");
            }
        }
    }
}
