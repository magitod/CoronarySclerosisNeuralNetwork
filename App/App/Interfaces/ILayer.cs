using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Interfaces
{
    interface ILayer
    {
        //Расчёт выходных сигналов со слоя
        double[] compute(double[] inputVector);

        //Выходные сигналы
        double[] LastOutput { get; }

        //Нейроны входящие в слой
        INeuron[] Neurons { get; }

        //Количество входных сигналов
        int InputDimension { get; }
    }
}
