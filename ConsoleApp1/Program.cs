using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] TimeToWakeUpStr = Console.ReadLine().Split(':');
            int[] TimeToWakeUp = new int[TimeToWakeUpStr.Length];

            for (int i = 0; i < TimeToWakeUp.Length; i++)
            {
                int time1 = int.Parse(TimeToWakeUpStr[i]);
                TimeToWakeUp[i] = time1;
            }

            DateTime now = DateTime.Now;

            DateTime start = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, 0);
            DateTime end = new DateTime(now.Year, now.Month, now.Day + 1, TimeToWakeUp[0], TimeToWakeUp[1], 0);

            TimeSpan duration = end - start;

            if (duration.Hours == 0)
                Console.WriteLine($"Будильник зазвонит через {duration.Minutes} минут.");
            else if (duration.Minutes == 0)
                Console.WriteLine($"Будильник зазвонит через {duration.Hours} час(часов).");
            else
                Console.WriteLine($"Будильник зазвонит через {duration.Hours} час(часов) и {duration.Minutes} минут.");
        }
    }
}
//DateTime start = new DateTime(2025, 3, 22, TimeToBed[0], TimeToBed[1], 0);
//DateTime end = new DateTime(2025, 3, 23, TimeToWakeUp[0], TimeToWakeUp[1], 0);
//TimeSpan duration = end - start;

//Console.WriteLine($"Разница: {duration.Hours} часов {duration.Minutes} минут");
