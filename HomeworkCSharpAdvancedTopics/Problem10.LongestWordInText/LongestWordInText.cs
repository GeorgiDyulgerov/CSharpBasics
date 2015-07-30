using System;
using System.Collections.Generic;
    class LongestWordInText
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(new char[] { ',', ';', ' ', '-', '.' },
        StringSplitOptions.RemoveEmptyEntries);
            string longestWord = words[0];
            for (int i = 0; i < words.Length; i++)
            {
                if (longestWord.Length > words[i].Length)
                {
                    continue;
                }
                else
                {
                    longestWord = words[i];
                }
            }
            Console.WriteLine(longestWord);

        }
    }
