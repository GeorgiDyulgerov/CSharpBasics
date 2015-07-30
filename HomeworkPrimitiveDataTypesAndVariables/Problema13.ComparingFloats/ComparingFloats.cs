using System;
    class ComparingFloats
    {
        static void Main()
        {
            bool result = false;
            Console.WriteLine("Enter the first number:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double b = double.Parse(Console.ReadLine());

            double deduction = a - b;
            Console.WriteLine(deduction);
            if (deduction < 0.000001)
            {
                result = true;
            }
            Console.WriteLine("({0};{1})->{2}", a, b, result);
        }
    }
