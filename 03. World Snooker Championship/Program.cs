using System;

namespace _03._World_Snooker_Championship
{
    class Program
    {
        static void Main(string[] args)
        {
            string final = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticketCount = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            double ticketPrice = 0;


            if (final == "Quarter final")
            {
                if (ticketType== "Standard")
                {
                    ticketPrice = ticketCount * 55.50;


                }
                else if (ticketType == "Premium")
                {
                    ticketPrice = ticketCount * 105.20;
                }
                else
                {
                    ticketPrice = ticketCount * 118.90;
                }
            }
            else if (final == "Semi final")
            {
                if (ticketType == "Standard")
                {
                    ticketPrice = ticketCount * 75.88;


                }
                else if (ticketType == "Premium")
                {
                    ticketPrice = ticketCount * 125.22;
                }
                else
                {
                    ticketPrice = ticketCount * 300.40;
                }
            }
           else
            {
                if (ticketType == "Standard")
                {
                    ticketPrice = ticketCount * 110.10;


                }
                else if (ticketType == "Premium")
                {
                    ticketPrice = ticketCount * 160.66;
                }
                else
                {
                    ticketPrice = ticketCount * 400;
                }

                
                
                
                
            }
              if (ticketPrice > 4000)
            {
                ticketPrice -= ticketPrice *( 25.0 / 100.0);
            }
            else if (ticketPrice > 2500)
            {
                ticketPrice -= ticketPrice / 10;
            if (symbol == 'Y')
            {
                ticketPrice += ticketCount * 40;


            }

            }
            
            Console.WriteLine($"{ticketPrice:f2}");
        }
    }
}
