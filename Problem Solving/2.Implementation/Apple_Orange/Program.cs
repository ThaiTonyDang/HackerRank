using System;
using System.Collections.Generic;

namespace Apple_Orange
{
    internal class Program
    {
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int applesCount = 0;
            int orangesCount = 0;

            for (int i = 0; i < apples.Count; i++)
            {
                if (a + apples[i] >= s && a + apples[i] <= t) applesCount++;
            }

            for (int i = 0; i < oranges.Count; i++)
            {
                if (b + oranges[i] >= s && b + oranges[i] <= t) orangesCount++;
            }

            Console.WriteLine(applesCount);
            Console.WriteLine(orangesCount);
        }

        static void Main(string[] args)
        {
            int s = 7;
            int t = 11;
            int a = 5;
            int b = 15;

            List<int> apples = new List<int> {-2 , 2 , 1 };
            List<int> oranges  = new List<int> { 5, -6 };
            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}
