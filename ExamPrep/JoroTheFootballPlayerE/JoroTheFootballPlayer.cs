using System;
    class JoroTheFootballPlayer
    {
        static void Main()
        {
            string year = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            switch(year)
            {
                case "t":
                    Console.WriteLine(Math.Floor((((52-h)*2/3)+p/2)+3+h));
                    break;
                case"f":
                    Console.WriteLine(Math.Floor((((52 - h) * 2 / 3) + p / 2) + h));
                    break;
            }
        }
    }
