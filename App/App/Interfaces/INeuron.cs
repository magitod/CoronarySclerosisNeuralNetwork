using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Interfaces
{
    interface INeuron
    {
        //Веса
        double[] Weights { get; set; }

        //Свободный вес
        double Bias { get; set; }

        //Вычислить состояние нейрона
        double activate(double[] inputVector);

        //Вычисление суммы входного сигнала
        double computeSum(double[] inputVector);

        //Последнее состояние
        double LastState { get; set; }

        //Последняя сумма
        double LastSum { get; set; }

        IList<INeuron> Childs { get; set; }

        IList<INeuron> Parents { get; set; }

        IFunction ActivationFunction { get; set; }
    }
}
