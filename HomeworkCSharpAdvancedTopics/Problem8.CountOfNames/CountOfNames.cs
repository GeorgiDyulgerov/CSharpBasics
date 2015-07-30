using System;
using System.Collections.Generic;
    class CountOfNames
    {
        static void Main()
        {
            string[] name = Console.ReadLine().Split();
            IDictionary<string, int> names = new SortedDictionary<string, int>();
            foreach (string nam in name)
            {
                if (string.IsNullOrEmpty(nam.Trim()))
                {
                    continue;
                }
                int count;
                if (!names.TryGetValue(nam, out count))
                {
                    count = 0;
                }
                names[nam] = count + 1;
            }
            foreach (KeyValuePair<string, int> itemEntry in names)
            {
                Console.WriteLine("{0} -> {1}", itemEntry.Key, itemEntry.Value);
            }
        }
    }
