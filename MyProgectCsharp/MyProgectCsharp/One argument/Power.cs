﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgectCsharp.One_argument
{
    class Power: IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}
