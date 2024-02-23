using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_3
{
    sealed class SteppedArray : BaseArray
    {
        //private int[][] _array;
        //private int _size;

        public SteppedArray(int[] size, bool isUser = false) : base(size, 2, isUser) { }

        public override double AverageValue()
        {
            double sum = 0;
            double count = 0;
            foreach (int[] item in _arrayS)
            {
                sum += item.Sum();
                count += item.Length;
            }
            return sum / count;
        }

        protected override void GetIntValues()
        {

            for (int i = 0; i < _size; i++)
            {
                Console.WriteLine($"Сколько элементов в ступене массива？");
                int collumn = int.Parse(Console.ReadLine());
                _arrayS[i] = new int[collumn];

                for (int j = 0; j < collumn; j++)
                {
                    Console.WriteLine($"элемент № {i}{j}");
                    _arrayS[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }

        protected override void GetRandomValues()
        {
            Random random = new Random();

            for (int i = 0; i < _arrayS.Length; i++)
            {
                int col = random.Next(3, 10);
                _arrayS[i] = new int[col];
                for (int j = 0; j < col; j++)
                {
                    _arrayS[i][j] = random.Next(0, 10);
                }
            }
        }

        public override void Print()
        {
            for (int i = 0; i < _arrayS.Length; i++)
            {
                for (int j = 0; j < _arrayS[i].Length; j++)
                {
                    Console.Write(_arrayS[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }


}
