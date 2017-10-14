using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Classes
{
    class DataItem<T>
    {
        #region Конструктор
        public DataItem(T[] input, T[] output)
        {
            Input = input;
            Output = output;
        }
        #endregion

        #region Свойства
        public T[] Input { get; set; }
        public T[] Output { get; set; }
        #endregion
    }
}
