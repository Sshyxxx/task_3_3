using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_3
{
    sealed class MultiplyDArray : BaseArray
    {
        //private int[,] _array;
        //private int _row;
        //private int _col;

        public MultiplyDArray(int[] size, bool isUser=false) : base(size, 1, isUser) { }

        public override double AverageValue()
        {
            int count = 0;
            double sum = 0;
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    sum += _arrayM[i, j];
                    count++;
                }
            }

            return sum / count;
        }


        protected override void GetIntValues()
        {
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    Console.WriteLine($"элемент № {j}");

                    _arrayM[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        protected override void GetRandomValues()
        {

            Random random = new Random();
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    _arrayM[i, j] = random.Next(0, 255);
                }
            }
        }

        public override void Print()
        {
            int rows = _arrayM.GetLength(0);
            int columns = _arrayM.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(_arrayM[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

    }


}
