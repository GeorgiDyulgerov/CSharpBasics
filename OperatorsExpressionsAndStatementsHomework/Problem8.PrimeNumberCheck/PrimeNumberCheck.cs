using System;
    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            bool Prime = true;
            if (n > 1 && n <= 100)
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine("Prime: " + !Prime);
                    }
                }
                        Console.WriteLine("Prime: " + Prime);
            }
            else { Console.WriteLine("Prime: " + !Prime); }
        }
    }
