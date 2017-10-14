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
        #region Свойства
        public int CountLayers { get; }
        public ILayer[] Layers { get; }
        #endregion

        #region Конструкторы
        //В конструктор передаётся массив параметров для нейронки 
        //количество элементов это количество внутренних слоёв, а сами элементы это количество нейронов в слое 
        //например: {1,2} - означает что сощздастся 2 внтуренних слоя, на первом слое будет 1 нейрон а на 2 два
        public NeuralNetwork(int[] configsLayers, int countInputs)
        {
            CountLayers = configsLayers.Length + 1;
            Layers = new Layer[CountLayers];
            if (configsLayers.Length != 0)
            {
                //Первый слой
                Layers[0] = new Layer(configsLayers[0], countInputs);

                //Внтуренние слои со 2 и остальные
                for (int i = 1; i < configsLayers.Length; i++)
                {
                    Layers[i] = new Layer(configsLayers[i], Layers[i-1].Neurons.Length);
                }

                //Выходной слой
                Layers[Layers.Length - 1] = new Layer(1, Layers[Layers.Length - 2].Neurons.Length);
            }
            else
            {
                Layers[0] = new Layer(1, countInputs);
            }
        }
        #endregion

        #region Методы

        public List<List<List<double>>> getAllWeights()
        {
            List<List<List<double>>> allWeights = new List<List<List<double>>>();
            for (int i = 0; i < CountLayers; i++)
            {
                allWeights.Add(new List<List<double>>());
                for (int j = 0; j < countNeurons(i); j++)
                {
                    allWeights[i].Add(new List<double>());
                    for (int q = 0; q < Layers[i].Neurons[j].Weights.Length; q++)
                    {
                        allWeights[i][j].Add(Layers[i].Neurons[j].Weights[q]);
                    }
                }
            }
            return allWeights;
        }

        public int countNeurons (int numberLayer)
        {
            numberLayer--;
            try
            {
                return Layers[numberLayer].CountNeurons;
            }
            catch
            {
                return 0;
            }
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
        #endregion
    }
}
