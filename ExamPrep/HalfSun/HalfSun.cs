using System;
using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] numbers1 = new int[n];
            int[] numbers2 = new int[n];
            int counter = 0;
            int D = 0;
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                numbers1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = n; i < 2 * n; i++)
            {

                numbers2[counter] = int.Parse(Console.ReadLine());
                counter++;
            }
            foreach (var num in numbers1)
            {
                sum1 += num;
            }
            foreach (var num2 in numbers2)
            {
                sum2 += num2;
            }
            if (sum1 == sum2)
            {
                int S = sum1;
                Console.WriteLine("Yes, sum={0}", S);
            }
            else
            {
                D = Math.Abs(sum1 - sum2);
                Console.WriteLine("No, diff={0}", D);
            }
        }
    }