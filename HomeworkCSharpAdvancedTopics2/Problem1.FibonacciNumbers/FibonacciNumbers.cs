using System;
class FibonacciNumbers
    {
        static void Main()
        {
            Console.Write("Enter number:");
            int n = int.Parse(Console.ReadLine());
            if(n==0||n==1)
            { 
                Console.WriteLine(1); 
            return;
            }
            Console.WriteLine( Fib(n) );
        }

        private static int Fib(int n)
        { 
            int a = 1, b = 1,fibonachiNumbers=1;
            
           for(int i=1;i<n;i++)
            {
            fibonachiNumbers=a+b;
                a = b;
                b = fibonachiNumbers;
            }
           return fibonachiNumbers;
        }
    }
