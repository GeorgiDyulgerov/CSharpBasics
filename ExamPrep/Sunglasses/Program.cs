using System;
using System.Linq;
class Sunglasses
{
    static void Main()
    {
        double N = double.Parse(Console.ReadLine());
        double x=((N/2)+0.5);
        int n = (int)N;
        for (int i = 1; i <= N; i++)
        {
            if (i == 1 || i == N)
            {
                Console.Write(string.Concat(Enumerable.Repeat("*", 2 * n)));
                Console.Write(string.Concat(Enumerable.Repeat(" ", n)));
                Console.Write(string.Concat(Enumerable.Repeat("*", 2 * n)));
                Console.WriteLine();
            }
            else
            {
                if (i == x)
                {
                    Console.Write("*");
                    Console.Write(string.Concat(Enumerable.Repeat("/", (2 * n) - 2)));
                    Console.Write("*");
                    Console.Write(string.Concat(Enumerable.Repeat("|", n)));
                    Console.Write("*");
                    Console.Write(string.Concat(Enumerable.Repeat("/", (2 * n) - 2)));
                    Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("*");
                    Console.Write(string.Concat(Enumerable.Repeat("/", (2 * n) - 2)));
                    Console.Write("*");
                    Console.Write(string.Concat(Enumerable.Repeat(" ", n)));
                    Console.Write("*");
                    Console.Write(string.Concat(Enumerable.Repeat("/", (2 * n) - 2)));
                    Console.Write("*");
                    Console.WriteLine();
                }
            }

        }
    }
}