using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class InsideTheBuilding
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            int[] x = new int[5];
            int[] y = new int[5];
            for (int i = 0; i < 5; i++)
            {
                x[i] = int.Parse(Console.ReadLine());
                y[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
               if(x[i]>=0&&x[i]<=3*h&&y[i]>=0&&y[i]<=h)
               {
                   Console.WriteLine("inside");
                   continue;
               }
                if(x[i]>=h&&x[i]<=2*h&&y[i]>=h&&y[i]<=4*h)
                {
                    Console.WriteLine("inside");
                    continue;
                }
                else
                {
                    Console.WriteLine("outside");
                }
            }

        }
    }
