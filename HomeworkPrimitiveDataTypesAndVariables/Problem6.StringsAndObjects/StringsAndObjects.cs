using System;
    class StringsAndObjects
    {
        static void Main()
        {
            string firstWord = "Hello";
            string secondWord = "World";
            object dataContainer = firstWord +" "+secondWord;
            string allInOne = dataContainer as string;
            Console.WriteLine(allInOne);

        }
    }

