using System;
    class Calculate
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int factorial1 = 1;
            int factorial2 = 1;
            for(int i=1;i<=n;i++)
            {
                factorial1 *= i;
                if(i<=k)
                {
                    factorial2 *= i;
                }
            }
            Console.WriteLine(factorial1/factorial2);
        }
    }
