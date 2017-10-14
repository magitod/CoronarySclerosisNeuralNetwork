using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Interfaces
{
    interface IFunction
    {
        //Расчёт значения
        double compute(double x);

        //Расчёт производной
        double computeFirstDerivative(double x);
    }
}
