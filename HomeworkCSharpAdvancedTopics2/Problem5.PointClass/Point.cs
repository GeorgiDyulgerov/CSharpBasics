using System;
class Point
    {
     public int x;
     public int y;


     public Point(int x, int y)
     {
         // TODO: Complete member initialization
         this.x = x;
         this.y = y;
     }
     public void PrintPoint()
     {
         Console.WriteLine("x={0}, y={1}",x,y);
     }
    }
