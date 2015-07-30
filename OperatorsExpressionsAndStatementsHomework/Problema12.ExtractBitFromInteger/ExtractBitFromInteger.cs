using System;
    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter position of bit: ");
            int p = int.Parse(Console.ReadLine());
            int nRightP = n >> p;
            int bit = nRightP & 1;
            Console.WriteLine(bit);   

        }
    }
