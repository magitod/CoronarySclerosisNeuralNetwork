using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Interfaces;

namespace App.Classes
{
    class LearningStrategy: ILearningStrategy<INeuralNetwork>
    {
        public void train(INeuralNetwork neuralNetwork, IList<DataItem<double>> data)
        {
            //код обучающей стратегии
        }
    }
}
