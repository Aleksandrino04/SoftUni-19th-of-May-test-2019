using System;

namespace _02._Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            double  lenghtMeters = double.Parse(Console.ReadLine());
            int secondsHundretMeters = int.Parse(Console.ReadLine());

            double matchSeconds = minutes * 60 + seconds;
            double reductionTimes = lenghtMeters / 120;
            double totalTimeReduced = reductionTimes * 2.5;
            double personalTime = (lenghtMeters / 100) * secondsHundretMeters - totalTimeReduced;
            if (personalTime <= matchSeconds)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {personalTime:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {(personalTime-matchSeconds):f3} second slower.");
            }







        }
    }
}
