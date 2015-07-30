using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class NineDigitMagicNumbers
    {
        static void Main()
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            int[] numbers1=new int[3];
            int[] numbers2=new int[3];
            int[] numbers3=new int[3];
            int result=0;
            Random r = new Random();
            do{
            for (int i = 0; i < 2; i++)
            {
                numbers1[i] = r.Next(1, 8);
            }
            for (int i = 0; i < 2; i++)
            {
                numbers2[i] = r.Next(1, 8);
            } 
            for (int i = 0; i < 2; i++)
            {
                numbers3[i] = r.Next(1, 8);
            }
                int sum1=numbers1.Sum();
                int sum2=numbers2.Sum();
                int sum3=numbers3.Sum();
                for (int i = 0; i < 2; i++)
			{
			  result=result +numbers1[i]+numbers2[i]+numbers3[i];
			}

            }
            while()
            {
        
        }

        }
    }