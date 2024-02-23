using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_3
{
    sealed class OneDArray : BaseArray
    {
        //private int[] _array;
        //private int _size;

        public OneDArray(int[] size, bool isUser = false) :base(size, 0, isUser) {
        }

        protected override void GetIntValues()
        {
            Console.WriteLine("введите " + _size + " элементов ");
            for (int i = 0; i < _arrayO.Length; i++)
            {
                Console.WriteLine($"элемент № {i}");
                _arrayO[i] = int.Parse(Console.ReadLine());
            }
        }

        public override double AverageValue()
        {
            int count = _arrayO.Length;
            double sum = 0;

            for (int i = 0; count > i; i++)
            {
                sum += _arrayO[i];
            }
            return sum / count;
        }

        protected override void GetRandomValues()
        {
            Random random = new Random();
            for (int i = 0; i < _size; i++)
            {
                _arrayO[i] = random.Next(0, 255);
            }
        }

        public override void Print()
        {
            foreach (int i in _arrayO)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

    }
}
