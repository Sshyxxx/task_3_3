using System;

namespace task_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OneDArray one = new OneDArray(new int[]{5});
            one.Print();

            MultiplyDArray multiplyD = new MultiplyDArray(new int[] {5, 5});
            multiplyD.Print();

            SteppedArray steppedArray = new SteppedArray(new int[] { 5 });
            steppedArray.Print();

            Calendarik calendar = new Calendarik();
            calendar.Print();
        }
    }
}
