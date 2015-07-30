using System;
class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int colum = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int x = i; x < 2 * n; x++)
            {
                if (colum <= n)
                {
                    Console.Write("{0} ", x);
                    colum++;
                }
            }

            Console.WriteLine();
            colum = 1;
        }
    }
}