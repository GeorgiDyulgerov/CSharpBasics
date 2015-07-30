using System;
class ModifyBitAtPosition
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter position of bit: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter value of bit: ");
        int value = int.Parse(Console.ReadLine());
        if (value == 0)
        {
            int mask = ~(1 << p);
            int result = n & mask;
            Console.WriteLine(result);
        }
        else
        {
            int mask = 1 << p;
            int result = n | mask;
            Console.WriteLine(result);
        }
    }
}
