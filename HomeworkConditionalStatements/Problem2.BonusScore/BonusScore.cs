﻿using System;
    class BonusScore
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            if (a<=0)
            { Console.WriteLine("invalid score"); }
            if (a>9)
            { Console.WriteLine("invalid score"); }
            switch(a)
            {
                case 1:
                    Console.WriteLine(a*10);
                    break;
                case 2:
                    Console.WriteLine(a * 10);
                    break;
                case 3:
                    Console.WriteLine(a * 10);
                    break;
                case 4:
                    Console.WriteLine(a * 100);
                    break;
                case 5:
                    Console.WriteLine(a * 100);
                    break;
                case 6:
                    Console.WriteLine(a * 100);
                    break;
                case 7:
                    Console.WriteLine(a * 1000);
                    break;
                case 8:
                    Console.WriteLine(a * 1000);
                    break;
                case 9:
                    Console.WriteLine(a * 1000);
                    break;
            }
        }
    }
