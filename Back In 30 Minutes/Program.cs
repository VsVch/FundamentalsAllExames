using System;

namespace Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            int allMinuties = hour * 60 + min + 30;
            int curHour = allMinuties / 60;
            int curMin = allMinuties % 60;
            if (curHour == 24)
            {
                curHour = 0;
            }

            Console.WriteLine($"{curHour}:{curMin:d2}");

            
        }
    }
}
