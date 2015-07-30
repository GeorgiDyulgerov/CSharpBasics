using System;
using System.Collections.Generic;
    class RemoveNames
    {
        static void Main()
        {
            List<string> names = new List<string>();
            string[] firstNames = Console.ReadLine().Split();
            List<string> removeNames = new List<string>();
            string[] delNames = Console.ReadLine().Split();
            for (int i = 0; i < firstNames.Length; i++)
            {
                names.Add(firstNames[i]);
            }
            for (int i = 0; i < delNames.Length; i++)
            {
                removeNames.Add(delNames[i]);
            }
            for (int i = 0; i < removeNames.Count; i++)
            {
                names.Remove(removeNames[i]);
                if(names.Contains(removeNames[i]))
                {
                    names.Remove(removeNames[i]);
                }
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
