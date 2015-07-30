using System;
    class DivideBy7And5
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            bool divideBy7And5 =true;
            if (number!=0&&number % 7 == 0)
            {
                if (number % 5 == 0)
                { Console.WriteLine("Divide bu 7 and 5: "+divideBy7And5); }
                else
                {
                    Console.WriteLine("Divide bu 7 and 5: " + !divideBy7And5);
                }
            }
            else 
            { 
                Console.WriteLine("Divide bu 7 and 5: " + !divideBy7And5);
            }
            
            
        }
    }
