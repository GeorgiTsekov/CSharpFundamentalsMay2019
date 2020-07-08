using System;

namespace onTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minuteExam = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minuteArrive = int.Parse(Console.ReadLine());

            int examTimeInMinutes = hourExam * 60 + minuteExam;
            int arriveTimeInMinutes = hourArrive * 60 + minuteArrive;
            int plusMinusTime = Math.Abs(arriveTimeInMinutes - examTimeInMinutes);
            int plusMinusInHours = Math.Abs(plusMinusTime / 60);
            int plusMinusInMinutes = plusMinusTime % 60;

            if (examTimeInMinutes < arriveTimeInMinutes)
            {
                Console.WriteLine("Late");
                if (plusMinusTime <= 59)
                {
                    Console.WriteLine($"{plusMinusTime} minutes after the start");
                }
                else if ((plusMinusTime > 59) && (plusMinusInMinutes <= 9))
                {
                    Console.WriteLine($"{plusMinusInHours}:0{plusMinusInMinutes} hours after the start");
                }
                else if (plusMinusTime > 59)
                {
                    Console.WriteLine($"{plusMinusInHours}:{plusMinusInMinutes} hours after the start");
                }
            }
            else if (examTimeInMinutes >= arriveTimeInMinutes)
            {
                if (plusMinusTime == 0)
                {
                    Console.WriteLine("On time");
                }
                else if (plusMinusTime <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{plusMinusTime} minutes before the start");
                }
                else if ((plusMinusTime > 30) && (plusMinusTime <= 59))
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{plusMinusTime} minutes before the start");
                }
                else if ((plusMinusTime > 59) && (plusMinusInMinutes <= 9))
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{plusMinusInHours}:0{plusMinusInMinutes} hours before the start");
                }
                else if ((plusMinusTime > 59) && (plusMinusInMinutes > 9))
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{plusMinusInHours}:{plusMinusInMinutes} hours before the start");
                }
            }

        }
    }
}
