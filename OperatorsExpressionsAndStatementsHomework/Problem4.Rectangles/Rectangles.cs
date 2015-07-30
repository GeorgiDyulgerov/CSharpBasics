using System;

    class Rectangles
    {
        static void Main()
        {
            Console.Write("Enter wildth: ");
            double wildth = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            double height = double.Parse(Console.ReadLine());
            double perimeter = (2 * wildth) + (2 * height);
            double area = wildth * height;
            Console.WriteLine("Perimeter: {0}\nArea: {1}",perimeter,area);



        }
    }
