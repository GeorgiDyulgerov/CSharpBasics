using System;
using System.Collections.Generic;
    class SortingNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> number = new List<int>();
            for(int i=0;i<n;i++)
            {
                number.Add(int.Parse(Console.ReadLine()));
            }
            number.Sort();
            foreach (var num in number)
            {
                Console.WriteLine(num);
            }
        }
    }
