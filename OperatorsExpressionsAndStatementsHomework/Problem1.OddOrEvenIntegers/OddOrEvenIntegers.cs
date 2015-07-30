using System;

    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.Write("Enter number:");
            int n = int.Parse(Console.ReadLine());
            bool Odd = true;
            int OddEven = n % 2;
            if(OddEven==0)
            { 
                Console.WriteLine(!Odd);
                Console.WriteLine(n + " is even");      
            }
            else
            {
                Console.WriteLine(Odd);
                Console.WriteLine(n+" is odd"); 
            }
        }
    }

