using System;
    class Trapezoids
    {
        static void Main()
        {
            Console.Write("Enter side a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter height h:");
            double h = double.Parse(Console.ReadLine());
            double S = 0.5 * (a + b) * h;
            Console.WriteLine("Trapezoid's area is: "+S);

        }
    }
