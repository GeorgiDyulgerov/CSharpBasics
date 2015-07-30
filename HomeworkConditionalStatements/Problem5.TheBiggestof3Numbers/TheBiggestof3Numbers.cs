using System;
    class TheBiggestof3Numbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double n=Math.Max(a,b);
            if (n < c)
            {
                Console.WriteLine(c);
            }
            else { Console.WriteLine(n); }
        }
    }
