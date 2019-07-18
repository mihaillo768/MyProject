﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgectCsharp.One_argument
{
    public class Arctan : IOneArgrumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Atan(first);
        }
    }
}
