using System;
    class CheckBitAtPosition
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter position of bit: ");
            int p = int.Parse(Console.ReadLine());
            int nRightP = n >> p;
            int bit = nRightP & 1;
            bool check = bit == 1;
            Console.WriteLine(check);
        }
    }
