using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Interfaces;

namespace App.Classes
{
    class NeuralNetwork: INeuralNetwork
    {
        public ILayer[] Layers { get; }

        //В конструктор передаётся массив параметров для нейронки 
        //количество элементов это количество внутренних слоёв, а сами элементы это количество нейронов в слое 
        //например: {1,2} - означает что сощздастся 2 внтуренних слоя, на первом слое будет 1 нейрон а на 2 два
        public NeuralNetwork(int[] configsLayers, int countInputs)
        {
            Layers = new Layer[configsLayers.Length + 2];

            //Первый слой
            Layers[0] = new Layer(configsLayers[0],countInputs);

            //Внтуренние слои со 2 и остальные
            for (int i = 1; i < configsLayers.Length; i++)
            {
                Layers[i + 1] = new Layer(configsLayers[i], Layers[i].Neurons.Length);
            }

            //Выходной слой
            Layers[Layers.Length - 1] = new Layer(1, Layers[Layers.Length - 2].Neurons.Length);
        }

        public double[] computeOutput(double[] inputVector)
        {
            double[] outputVector = inputVector;
            foreach (ILayer layer in Layers)
            {
                outputVector = layer.compute(outputVector);
            }

            return outputVector;
        }

        public void train(IList<DataItem<double>> data)
        {
            LearningStrategy strategy = new LearningStrategy();
            strategy.train(this, data);
        }
    }
}
