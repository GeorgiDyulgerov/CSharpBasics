using System;
    class PointInCircle
    {
        static void Main()
        {
            bool check = false;
            double X, Y;
            Console.Write("Enter X:");
            bool Xcheck = double.TryParse(Console.ReadLine(),out X);
            Console.Write("Enter Y:");
            bool Ycheck = double.TryParse(Console.ReadLine(),out Y);
            if (Xcheck && Ycheck)
            {
                if ((X * X + Y * Y) <= 4)
                {
                    check = true;
                }
                Console.WriteLine("Is the point ({0},{1}) within the circle?:{2}", X, Y, check);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
