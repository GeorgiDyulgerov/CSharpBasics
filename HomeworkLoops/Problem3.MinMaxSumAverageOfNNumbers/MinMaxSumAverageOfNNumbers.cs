using System;
    class MinMaxSumAverageOfNNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int []number=new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
              number[i] =int.Parse(Console.ReadLine());
               sum += number[i];
            }
            int min = number[0];
            int max = number[0];
            double avarage=number[0];
            for (int i = 1; i < n;i++)
            {
                if(min>number[i])
                {
                    min=number[i];
                }
                if(max<number[i])
                {
                    max = number[i];
                }
                avarage += number[i];
            }
                Console.WriteLine("sum={0}", sum);
                Console.WriteLine("min={0}",min);
                Console.WriteLine("max={0}",max);
                Console.WriteLine("avg={0:0.00}", avarage/n);
        }
    }
