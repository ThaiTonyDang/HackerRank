using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthDay_Cake
{
    internal class Program
    {
        public static int CountBirthdayCakeCandles(List<int> candles)
        {
            int numberOfHighestCandles = 0;
            int maxHight = candles[0];
            for (int i = 0; i <= candles.Count() - 1; i++)
            {
                if (candles[i] > maxHight)
                {
                    maxHight = candles[i];
                    numberOfHighestCandles = 1;
                }
                else if (candles[i] == maxHight)
                {
                    numberOfHighestCandles++;
                }
            }

            return numberOfHighestCandles;
        }

        //candles = [4, 4, 1, 3] = > 2
        public static int FindMaxInArray(int[] candles)
        {
            int max = candles[0];
            for (int i = 0; i < candles.Length; i++)
            {
                if (max < candles[i])
                {
                    max = candles[i];
                }
            }

            return max;
        }

        public static int CountMaxInArray(int[] candles)
        {
            int count = 0;
            int max = FindMaxInArray(candles);
            for ( int i = 0; i < candles.Length; i++)
            {
                if (max == candles[i])
                {
                    count++;
                }
            }

            return count;
        }
        static void Main(string[] args)
        {
            List<int> candles = [ 4, 4, 5, 1,5, 3, 4, 5 ];
            int maxNumberOfcandles = CountBirthdayCakeCandles(candles);
            Console.WriteLine($"The highest number of candles is : {maxNumberOfcandles}" );
        }
    }
}