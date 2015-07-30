using System;
    class PrintTheASCIITable
    {
      static void Main()
        {
            for (int ASCII = 0; ASCII <= 255; ASCII++)
            {
                Console.WriteLine((char)ASCII);
            }
        }
    }