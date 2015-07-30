using System;
    class NumberComparer
    {
        static void Main()
        {
            Console.WriteLine("Enter two numbers to see wich is greater: ");
            try
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Greater is: "+ Math.Max(a,b));   
            }
            catch (Exception)
            { Console.WriteLine("Invalid number!"); }

        }
    }
