using System;
using System.Globalization;
    class BeerTime
    {
        static void Main()
        {
            Console.Write("Enter time i format “hh:mm tt”:");
            string time = Console.ReadLine();
            DateTime enterTime = DateTime.ParseExact(time,"h:mm tt", CultureInfo.InvariantCulture);
            DateTime startTime = DateTime.Parse("1:00 PM");
            DateTime endTime = DateTime.Parse("3:00 AM");
            if (enterTime >= startTime || enterTime <= endTime)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }


        }
    }
