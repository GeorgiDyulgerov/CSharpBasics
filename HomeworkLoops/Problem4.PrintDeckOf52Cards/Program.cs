using System;
    class Program
    {
        static void Main()
        {
            for (int ASCII = 0; ASCII <= 255; ASCII++)
            {
                string card = Convert.ToString((char)ASCII);
                switch(card)
                {
                    case"2":
                        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠",card);
                        break;
                    case "3": 
                        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", card);
                        break;
                    case "4": 
                        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", card);
                        break;
                    case "5": 
                        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", card);
                        break;
                    case "6":
                        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", card);
                        break;
                    case "7": 
                        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", card);
                        break;
                    case "8": 
                        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", card);
                        break;
                    case "9":
                        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", card);
                        break;
                    case "10": 
                        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", card);
                        break;
                    case "J": 
                        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", card);
                        break;
                    case "Q": 
                        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", card);
                        break;
                    case "K": 
                        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", card);
                        break;
                    case "A": 
                        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", card);
                        break;
                    default:
                        continue;
                }

            }
        }
    }
