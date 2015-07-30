using System;
    class SumOf5Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enter 5 numbers separated by a space: ");
            string[] sumOf5Numbers = new string[5];
            double sum = 0;
            sumOf5Numbers = Console.ReadLine().Split();
            for (int i = 0; i < sumOf5Numbers.Length; i++)
            {
                sum += Convert.ToDouble(sumOf5Numbers[i]);
            }
            Console.WriteLine(sum);

        }
    }
