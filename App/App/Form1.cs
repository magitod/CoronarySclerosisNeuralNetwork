using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Classes;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // создание нейронки с 2 внутренними слоями, 1 слой 2 нейрона, 2 слой 5 нейронов и 3 слой(выходной, есть всегда) с 1 нейроном
            int[] configLayers = { 2, 5 };
            NeuralNetwork network = new NeuralNetwork(configLayers, 4);

            double[] inputVector = { 0.5, 1, 0, 1 };
            label1.Text = String.Format(
                "Кол-во слоёв: {0}\r\nСлой 1 кол-во нейронов:{1}\r\nВыходной сигнал:{2}", 
                network.CountLayers, 
                network.countNeurons(1),
                network.computeOutput(inputVector)[0]
            );
        }
    }
}
