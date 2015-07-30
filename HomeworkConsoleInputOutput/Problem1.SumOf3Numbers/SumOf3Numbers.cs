using System;
    class SumOf3Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enter 3 numbers to see their sum:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.Write("Sum=");
            Console.WriteLine(a+b+c);
        }
    }
