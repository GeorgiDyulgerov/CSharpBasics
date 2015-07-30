using System;

    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("Enter four digit number: ");
            int n = int.Parse(Console.ReadLine());
                if(n>=1000 && n<=9999)
                {
                    int a = n / 1000;
                    int b = (n / 100) % 10;
                    int c = (n / 10) % 10;
                    int d = n % 10;
                    int sum = a + b + c + d;
                    Console.WriteLine("Sum of digits: "+sum);
                    Console.WriteLine("Reversed: " + d + c + b + a);
                    Console.WriteLine("Last digit in front: "+d+a+b+c);
                    Console.WriteLine("second and third digits exchanged: "+a+c+b+d);
                }
                else
                { Console.WriteLine("The number must have exactly 4 digits."); }
        }
    }

