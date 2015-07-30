using System;
    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("Enter coefficents a, b, c of a quadratic equation:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double rootx1 = -(b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            double rootx2 = -(b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            Console.WriteLine("x1={0}; x2={1}",rootx1,rootx2);
        }
    }
