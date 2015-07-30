using System;

    class ThirdDigitIs7
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            int check = (n / 100) % 10;
            bool thirdDigit7 = true;
            if(check==7)
            { Console.WriteLine("Third digit is 7: "+thirdDigit7); }
            else{Console.WriteLine("Third digit is 7: "+!thirdDigit7);}
        }
    }
