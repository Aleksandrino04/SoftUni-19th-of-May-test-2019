using System;

namespace _04._Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            int totalPoints = 301;
            int accurateShots = 0;
            int inaccurateShots = 0;
            while (totalPoints != 0)
            {
                string result = Console.ReadLine();
                if (result == "Retire")
                {
                    break;
                }
                int points = int.Parse(Console.ReadLine());
                if (result == "Double")
                {
                    points *= 2;
                }
                else if (result == "Triple")
                {
                    points *= 3;
                }
                if (totalPoints - points >= 0)
                {
                    totalPoints -= points;
                    accurateShots++;
                }
                else
                {
                    inaccurateShots++;
                }
                
            }
            if (totalPoints == 0)
            {
                Console.WriteLine($"{playerName} won the leg with {accurateShots} shots.");
            }
            else
            {
                Console.WriteLine($"{playerName} retired after {inaccurateShots} unsuccessful shots.");

            }
        }
    }
}
