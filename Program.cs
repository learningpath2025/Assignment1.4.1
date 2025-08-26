//Create a structure named “Point” and 2 data members: X and Y coordinate. Declare 2 points: P1 and P2.
//Determine if P2 is to the right or left of P1 or on same axis , by comparing the x xoordinates. ( if p1.x is more than p2.x , it is to the right )
using System;
using System.Drawing;

namespace Assignment1._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point P1 = new Point();
            Point P2 = new Point();
            P1.X = 10;
            P1.Y = 20;
            P2.X = 10;
            P2.Y = 40;
            Console.WriteLine(P1.Compare(P2));


        }

        public struct Point
        {
            public int X;
            public int Y;
            public string Compare(Point p)
            {
                if (this.X > p.X)
                {
                    return "P2 is to the left of P1";
                }
                else if (this.X < p.X)
                {
                    return "P2 is to the right of P1";
                }
                else
                {
                    return "P2 is on the same axis as P1";
                }
            }
        }
    }
}
