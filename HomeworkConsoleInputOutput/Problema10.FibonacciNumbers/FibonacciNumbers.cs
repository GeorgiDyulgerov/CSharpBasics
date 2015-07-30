using System;
    class FibonacciNumbers
    {
        static void Main()
        {
            Console.Write("Enter number:");
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 1;
            if(n==1)
            { Console.WriteLine(0); 
            return;
            }
                Console.Write("{0} {1} ",a,b);
           for(int i=2;i<n;i++)
            {
            int fibonachiNumbers=a+b;
                Console.Write("{0} ",fibonachiNumbers);
                a = b;
                b = fibonachiNumbers;
            }
        }
    }
