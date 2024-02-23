using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace task_3_3
{
    public class Calendarik : IPrinter
    {
        DateTime _time;


        public Calendarik()
        {
            //_time = new DateTime();
            _time = DateTime.Now;

        }

        public void Print()
        {
            for (int i = 0; i < 7; i++)
            {
                _time += TimeSpan.FromDays(1);
                Console.WriteLine($"{i + 1}： " + _time.DayOfWeek);
            }

        }
    }
}
