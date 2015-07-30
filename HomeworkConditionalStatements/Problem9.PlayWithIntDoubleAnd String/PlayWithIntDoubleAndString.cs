using System;

    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            Console.Write(@"Please choose a type:
1 --> int
2 --> double
3 --> string
");
            string type = Console.ReadLine();
            switch(type)
            {
                case"1":
                    Console.Write("Please enter a int: ");
                    int intNum = int.Parse(Console.ReadLine());
                    Console.WriteLine(intNum+1);
                    break;
                case"2":
                    Console.Write("Please enter a double: ");
                    double doubleNum = double.Parse(Console.ReadLine());
                    Console.WriteLine(doubleNum+1);
                    break;
                case"3":
                    Console.Write("Please enter a string: ");
                    string phrase = Console.ReadLine();
                    Console.WriteLine(phrase+"*");
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }

        }
    }
