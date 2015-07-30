using System;
using System.Collections.Generic;
    class CountofLetters
    {
        static void Main()
        {
            string[] letter = Console.ReadLine().Split();
            IDictionary<string, int> letters =new SortedDictionary<string, int>();
            foreach (string lett in letter)
            {
                if (string.IsNullOrEmpty(lett.Trim()))
                {
                    continue;
                }
                int count;
                if (!letters.TryGetValue(lett, out count))
                {
                    count = 0;
                }
                letters[lett] = count + 1;
            }
            foreach (KeyValuePair<string, int> letterEntry in letters)
            {
                Console.WriteLine("{0} -> {1}", letterEntry.Key, letterEntry.Value);
            }
        }
    }
