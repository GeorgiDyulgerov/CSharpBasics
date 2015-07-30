using System;
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("Enter radius \"r\": ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine(@"Perimeter={0:#.##}
Area={1:#.##}",2*Math.PI*r,Math.PI*r*r);
        }
    }
