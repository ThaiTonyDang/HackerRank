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
            var result = kangaroo(4523, 8092, 9419, 8076);
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

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            bool flag = false;
            int time = 0;

            if (x1 > x2 || v1 <= v2)
            {
                return "NO";
            }
            else
            {
                for (time = 1; time * v2 + x2 <= 20000000; time++)
                {
                    if (x1 + (v1 * time) == x2 + (v2 * time))
                    {
                        flag = true;
                        break;
                    }
                }

                var t2 = x2 + (v2 * time);
                var t1 = x1 + (v1 * time);
                if (flag) return "YES";
                return "NO";
            }
        }
    }
}