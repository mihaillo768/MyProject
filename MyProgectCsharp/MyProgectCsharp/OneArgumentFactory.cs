using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgectCsharp
{
    class OneArgumentFactory
    {
        public static IOneArgrumentCalculator CreateCalculator(string operationName)
        {
            switch (operationName)
            {
                case "Sinus":
                    return new Sinus();
                default:
                    throw new Exception("Несуществующая операция");
            }
        }
    }
}
