using System;
    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            if (Math.Max(a, b) <= Math.Max(c, d) || Math.Max(a, b) <= e)
            {
            if (Math.Max(c,d)>=e)
            { Console.WriteLine(Math.Max(c, d)); }
            if (Math.Max(c, d) <= e)
                { Console.WriteLine(e); }
            }
            else { Console.WriteLine(Math.Max(a, b)); }
        }
    }
