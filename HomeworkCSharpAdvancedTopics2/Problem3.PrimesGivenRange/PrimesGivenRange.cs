using System;
using System.Collections.Generic;
    class PrimesGivenRange
    {
        static void Main()
        {
            int startNum=int.Parse(Console.ReadLine());
            int endNum=int.Parse(Console.ReadLine());
            List<int> primes = FindPrimesInRange(startNum, endNum);

            for (int i = 0; i < primes.Count; i++)
            {
                if (i < primes.Count - 1)
                {
                    Console.Write("{0}, ", primes[i]);
                }
                else
                {
                    Console.WriteLine(primes[i]);
                }
            }

        }
        static List<int> FindPrimesInRange(int startNum, int endNum)
            {
                List<int> primesCollection = new List<int>();

                if (startNum < 2)
                {
                    startNum = 2;
                }

                for (int i = startNum; i <= endNum; i++)
                {
                    int divider = 2;
                    double maxDivider = Math.Sqrt(i);
                    bool isPrime = true;

                    while (divider <= maxDivider)
                    {
                        if (i % divider == 0)
                        {
                            isPrime = false;
                            break;
                        }

                        divider++;
                    }

                    if (isPrime)
                    {
                        primesCollection.Add(i);
                    }
                }

                return primesCollection;
            }
            }