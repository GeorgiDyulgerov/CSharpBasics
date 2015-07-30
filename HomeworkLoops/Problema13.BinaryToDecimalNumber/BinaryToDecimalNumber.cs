using System;
    class BinaryToDecimalNumber
    {
        static void Main()
        {
            string binary = Console.ReadLine();
            long decimalNum = 0;
            for(int i=0;i<binary.Length;i++)
            {
                if (binary[binary.Length - i - 1] == '0')
                {
                    continue;
                }
                decimalNum += (long)Math.Pow(2, i);
            }
            Console.WriteLine(decimalNum);
        }
    }
