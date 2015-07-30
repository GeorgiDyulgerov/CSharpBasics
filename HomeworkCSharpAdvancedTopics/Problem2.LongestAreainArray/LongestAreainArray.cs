using System;
using System.Collections.Generic;
class LongestAreainArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] words = new string[n];
        int longestSequence = 1, currentSequence = 0;
        string checkWords = "",result="";
        for (int i = 0; i < n; i++)
        {
            words[i] = Console.ReadLine();
            if (checkWords == words[i])
            {
                currentSequence++;
                if (currentSequence > longestSequence)
                {
                    longestSequence = currentSequence;
                    result=words[i];
                }
            }
            else
            {
                currentSequence = 1;
            }
            checkWords = words[i];
        }
            Console.WriteLine(longestSequence);
 
        for (int i = 1; i <= longestSequence; i++)
        {
            Console.WriteLine(result);
        }
    }

        }

