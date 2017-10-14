﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Interfaces;

namespace App.Classes
{
    class SigmoidFunction: IFunction
    {
        public double Alpha { get; set; }

        public SigmoidFunction()
        {
            Alpha = 1.0;
        }

        public SigmoidFunction(double alpha)
        {
            Alpha = alpha;
        }

        public double compute(double x)
        {
            double result = (1.0 / (1.0 + Math.Exp(-Alpha * x)));
            return result;
        }

        public double computeFirstDerivative(double x)
        {
            double f = compute(x);
            double firstDerivative = Alpha * f * (1 - f);
            return firstDerivative;
        }
    }
}
