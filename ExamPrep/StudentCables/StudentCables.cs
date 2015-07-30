using System;

    class StudentCables
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] cables = new int[n];
            string[] length = new string[n];
            int allcables = 0;
            int studentCable=504;
            int counter=0;
            for (int i = 0; i < n; i++)
            {
                cables[i]=int.Parse(Console.ReadLine());
                length[i] = Console.ReadLine();
            }
            for (int i = 0; i < n; i++)
            {
                if(length[i]=="meters")
                {
                    cables[i] *= 100;
                }
                if(cables[i]>=20)
                {
                    allcables = allcables + cables[i];
                    counter++;
                }
            }
            allcables = allcables - 3 * (counter - 1);

            int cablesCount = allcables / 504;
            int remainder = allcables % 504;

            Console.WriteLine(cablesCount);
            Console.WriteLine(remainder);
        }
    }
