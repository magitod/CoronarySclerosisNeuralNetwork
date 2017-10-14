using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Classes;

namespace App.Interfaces
{
    interface ILearningStrategy<T>
    {
        //Обучить нейронную сеть
        void train(T network, IList<DataItem<double>> data);
    }
}
