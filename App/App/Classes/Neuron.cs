using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Interfaces;

namespace App.Classes
{
    class Neuron: INeuron
    {
        Random r = new Random();
        #region Свойства
        public double[] Weights { get; set; }

        public double Bias { get; set; }

        public double LastState { get; set; }

        public double LastSum { get; set; }

        public IList<INeuron> Childs { get; set; }

        public IList<INeuron> Parents { get; set; }

        public IFunction ActivationFunction { get; set; }
        #endregion

        #region Функции


        public double computeSum(double[] inputVector)
        {
            double sum = Bias;
            foreach (double value in inputVector)
            {
                sum += value;
            }
            LastSum = sum;
            return LastSum;
        }

        public double activate(double[] inputVector)
        {
            double x = computeSum(inputVector);
            double f = ActivationFunction.compute(x);
            LastState = f;
            return LastState;
        }

        #endregion

        public Neuron(int countInputs)
        {
            Weights = new double[countInputs];

            //рандомайз начальных весов
            Bias = r.NextDouble();

            for (int i = 0; i < countInputs; i++)
            {
                Weights[i] = r.NextDouble();
            }
        }
    }
}
