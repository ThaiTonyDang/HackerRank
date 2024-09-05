using System;
using System.Collections.Generic;
using System.Linq;

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
            List<int> a = new List<int> { 2, 3 };
            List<int> b = new List<int> { 16, 32, 96 };
            int total = getTotalX(a, b);
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
    }  
}