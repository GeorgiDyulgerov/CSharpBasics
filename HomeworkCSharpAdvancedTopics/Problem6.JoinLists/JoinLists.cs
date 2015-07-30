using System;
using System.Collections.Generic;
    class JoinLists
    {
        static void Main()
        {
            List<string> numbers = new List<string>();
            string[] firstNumbers = Console.ReadLine().Split();
            List<string> addNumbers = new List<string>();
            string[] addNums = Console.ReadLine().Split();
            for (int i = 0; i < firstNumbers.Length; i++)
            {
                numbers.Add(firstNumbers[i]);
            }
            for (int i = 0; i < addNums.Length; i++)
            {
                addNumbers.Add(addNums[i]);
            }
            for (int i = 0; i < firstNumbers.Length; i++)
            {
                if (!addNumbers.Contains(numbers[i]))
                {
                    addNumbers.Add(numbers[i]);
                }
                else
                {
                    continue;
                }
            }
            addNumbers.Sort();
            foreach (var result in addNumbers)
            {
                Console.Write("{0} ", result);
            }

        }
    }
