using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace task_3_3
{
    public abstract class BaseArray : IArray, IPrinter
    {

        protected int[] _arrayO;
        protected int[,] _arrayM;
        protected int[][] _arrayS;

        protected int _size;
        protected int _row;
        protected int _col;

        /// <summary>
        /// Конструктор массива
        /// size - размер массива, для одномерного и ступенчатого элемент [0]
        /// type - 0 для одномерного, 1 для двумерного, 2 для ступенчатого
        /// </summary>   
        protected BaseArray(int[] size, int type, bool isUser = false)
        {
            if(type== 0)
            {
                _size = size[0];
                _arrayO = new int[size[0]];
            }
            else if (type == 1)
            {
                _arrayM = new int[size[0], size[1]];
                _row = size[0];
                _col = size[1];
            }
            else
            {
                _size = size[0];
                _arrayS = new int[size[0]][];
            }

            if (!isUser)
            {
                GetRandomValues();
            }
            else
            {
                GetIntValues();
            }
        }


        /// <summary>
        /// Заполнение массива целыми числами
        /// </summary>     
        protected abstract void GetIntValues();


        /// <summary>
        /// Заполнение массива случайными числами
        /// </summary>     
        protected abstract void GetRandomValues();

        /// <summary>
        /// Выводит на экран массив
        /// </summary>    
        public abstract void Print();


        /// <summary>
        /// Считает среднее значение массива
        /// </summary>
        /// <returns>Дробное число, сумма, поделенная на количество элементов</returns>
        public abstract double AverageValue();

    }
}
