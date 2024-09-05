using System;

namespace Number_Line_Jumps
{
    internal class Program
    {
        /*
         You are choreographing a circus show with various animals. 
        For one act, you are given two kangaroos on a number line ready to jump in the positive direction
        (i.e, toward positive infinity).

        The first kangaroo starts at location  and moves at a rate of  meters per jump.
        The second kangaroo starts at location  and moves at a rate of  meters per jump.
        You have to figure out a way to get both kangaroos at the same location at the same time as part of the show.
        If it is possible, return YES, otherwise return NO.
         
        */
        static void Main(string[] args)
        {
            var result = IsKangarooJumps(4, 8, 10, 6) ? "YES" : "NO";
            Console.WriteLine(result); // YES
        }

        public static bool IsKangarooJumps(int x1, int v1, int x2, int v2)
        {
            if (v2 > v1) return false;
            if (x2 < x1) return false;
            
            int timeModul = (x2 - x1) % (v1 - v2);
            if (timeModul == 0) return true;
            return false;
        }
    }
}