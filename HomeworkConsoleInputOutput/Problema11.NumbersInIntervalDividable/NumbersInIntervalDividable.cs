using System;
    class NumbersInIntervalDividable
    {
        static void Main()
        {
            Console.Write("Enter number for START: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter number for END: ");
            int end = int.Parse(Console.ReadLine());
            int p = 0;
            for(int i=start;i<=end;i++)
            {
                if(i%5==0)
                {
                    Console.WriteLine(i);
                    p++;
                }
            }
            Console.WriteLine("Numbers dividet by \"5\": "+p);
        }
    }
