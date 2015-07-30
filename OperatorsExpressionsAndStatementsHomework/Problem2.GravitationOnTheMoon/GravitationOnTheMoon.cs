using System;

    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.Write("Enter your weight: ");
            double Weight = double.Parse(Console.ReadLine());
            double WeightOnMoon = Weight * 0.17;
            Console.WriteLine("Your weght on the Moon is: "+WeightOnMoon);
        }
    }