using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Classes;

namespace App.Interfaces
{
    interface INeuralNetwork
    {

        //Слои
        ILayer[] Layers { get; }

        //Расчитать выход
        double[] computeOutput(double[] inputVector);

        //Обучение
        void train(IList<DataItem<double>> data);
    }
}
