using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Between_Two_Sets
{
    internal class Program
    {
        // {2, 4} 4, 8, 16 
        // {16, 32, 96}  16, 4 , 8 
        // 3


        // {2 , 6} // 6, 12, 24
        // {24, 36} // 12, 6
        //  2
        static void Main(string[] args)
        {
            List<int> a = new List<int> { 5, 45 };
            List<int> b = new List<int> { 16, 32, 96 };
            int total = getTotalX(a, b);

            //int lcmA = a[0];
            //for (int i = 1; i < a.Count; i++)
            //{
            //    lcmA = LCM(lcmA, a[i]);
            //}

            //int gcdB = b[0];
            //for (int i = 1; i < b.Count; i++)
            //{
            //    gcdB = GCD(gcdB, b[i]);
            //}

            //int total = 0;
            //for (int i = lcmA; i <= gcdB; i += lcmA)
            //{
            //    if (gcdB % i == 0)
            //    {
            //        total ++;
            //    }
            //}

            Console.WriteLine(total);
        }

        public static int getTotalX(List<int> a, List<int> b)
        {
            var count = 0;
            var maximumA = a.Max();
            var minimumB = b.Min();
            var multiplier = 1;
            var multipleOfMaxA = maximumA;

            while (multipleOfMaxA <= minimumB)
            {
                var factor = true;

                foreach (var item in a)
                {
                    if (multipleOfMaxA % item != 0)
                    {
                        factor = false;
                        break;
                    }
                }

                if (factor)
                {
                    foreach (var item in b)
                    {
                        if (item % multipleOfMaxA != 0)
                        {
                            factor = false;
                            break;
                        }
                    }
                }

                if (factor)
                    count++;

                multiplier++;
                multipleOfMaxA = maximumA * multiplier;
            }
            return count;
        }

        public static int LCM(int a, int b)
        {
            return (a * b) / GCDLinQ(a, b);
        }

        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static int ExtendedGCD(int a, int b, out int x, out int y)
        {
            if (b == 0)
            {
                x = 1;
                y = 0;
                return a;
            }

            int gcd = ExtendedGCD(b, a % b, out x, out y);
            int temp = x;
            x = y;
            y = temp - (a / b) * y;

            return gcd;
        }

        public static int GCDLinQ(int a, int b)
        {
            return Enumerable.Range(1, Math.Min(a, b))
                             .Where(x => a % x == 0 && b % x == 0)
                             .Max();
        }

        public static BigInteger BigGCD(BigInteger a, BigInteger b)
        {
            return BigInteger.GreatestCommonDivisor(a, b);
        }
    }
}