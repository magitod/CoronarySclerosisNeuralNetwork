using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Interfaces;

namespace App.Classes
{
    class Layer: ILayer
    {
        private double[] lastOutput;

        public double[] LastOutput { get { return lastOutput; } }
        public INeuron[] Neurons { get; }
        public int InputDimension { get; }

        public Layer(int countNeuron, int countInputs)
        {
            Neurons = new Neuron[countNeuron];
            for (int i = 0; i < countNeuron; i++)
            {
                Neurons[i] = new Neuron(countInputs);
            }
        }

        public double[] compute(double[] inputVector)
        {
            double[] outputVector = new double[Neurons.Length];
            for (int i = 0; i < Neurons.Length; i++)
            {
                outputVector[i] = Neurons[i].activate(inputVector);
            }

            lastOutput = outputVector;

            return LastOutput;
        }

    }
}
