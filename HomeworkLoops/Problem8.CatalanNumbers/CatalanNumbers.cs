using System;
using System.Numerics;
    class CatalanNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorialN=1;
            BigInteger factorial2N=1;
            BigInteger factorialNplus=1;
            for(int i=1;i<=2*n;i++)
            {
                factorial2N *= i;
                if (i <= n)
                {
                    factorialN *= i;
                }
                if (i <= n+1)
                {
                    factorialNplus *= i;
                }
            }
                Console.WriteLine((factorial2N/(factorialN*factorialNplus)));
            }
        }
