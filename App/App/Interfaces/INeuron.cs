using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Interfaces
{
    interface INeuron
    {
        /// <summary>
        /// Веса 
        /// </summary>
        double[] Weights { get; set; }

        /// <summary>
        /// Свободный вес
        /// </summary>      
        double Bias { get; set; }

        /// <summary>
        /// Вычислить состояние нейрона
        /// </summary>
        /// <param name="inputVector">Входной сигнал</param>
        /// <returns>Состояние нейрона</returns>        
        double activate(double[] inputVector);

        /// <summary>
        /// Вычислить взвешенную сумму
        /// </summary>
        /// <param name="inputVector">Входной сигнал</param>
        /// <returns>Взвешенная сумма</returns>
        double computeSum(double[] inputVector);

        /// <summary>
        /// Последнее вычисленное состояние нейрона
        /// </summary>
        double LastState { get; set; }

        /// <summary>
        /// Последняя вычисленная взвешенная сумма нейрона
        /// </summary>     
        double LastSum { get; set; }

        IList<INeuron> Childs { get; set; }

        IList<INeuron> Parents { get; set; }

        IFunction ActivationFunction { get; set; }
    }
}
