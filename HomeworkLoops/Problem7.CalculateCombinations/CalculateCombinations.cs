using System;
using System.Numerics;
    class CalculateCombinations
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger factorial1 = 1;
            BigInteger factorial2 = 1;
            BigInteger factorialDiff = 1;
            int check = n - k;
            for (int i = 1; i <= n; i++)
            {
                factorial1 *= i;
                if (i <= k)
                {
                    factorial2 *= i;
                }
                if (i <=check)
                {
                    factorialDiff *= i;
                }
            }
            Console.WriteLine(factorial1 / (factorial2*factorialDiff));
        }
    }
