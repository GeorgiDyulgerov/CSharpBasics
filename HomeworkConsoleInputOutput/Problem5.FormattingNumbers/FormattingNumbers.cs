using System;
    class FormattingNumbers
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter 3 numbers");
                int a = int.Parse(Console.ReadLine());
                float b = float.Parse(Console.ReadLine());
                float c = float.Parse(Console.ReadLine());
                Console.WriteLine("|{0,-10:X}|{1,-10}|{2,10:F2}|{3,-10:F3}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
            }
            catch (Exception)
            {
                Console.WriteLine("Error!Try again.");
            }
        }
    }
