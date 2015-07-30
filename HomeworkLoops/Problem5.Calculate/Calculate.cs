using System;
    class Calculate
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            double divisor = x;
            double factorial = 1;
            double sum;
            sum = 1 + (factorial/divisor);
            for(int i=2;i<=n;i++)
            {
                factorial *= i;
                divisor *= x;
                sum+=(factorial / divisor);

            }
            Console.WriteLine("{0:0.00000}",sum);
        }
    }
