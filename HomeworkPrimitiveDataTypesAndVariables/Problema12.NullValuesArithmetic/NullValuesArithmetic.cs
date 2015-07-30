using System;
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? a=null;
            double? b=null;
            Console.WriteLine(a+" "+b);
            int? c = a + 10;
            double? d = b + 10.5;
            Console.WriteLine(c+" "+d);
            c = a + 10;
            d = b + 10.5;
            Console.WriteLine(c.GetValueOrDefault()+" "+d.GetValueOrDefault());
        }
    }
