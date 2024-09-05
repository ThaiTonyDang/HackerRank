using System;

namespace BirthDay_Cake
{
    internal class Program
    {
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
            int[] candles = { 4, 4, 1, 3 };
            int maxNumberOfcandles = CountMaxInArray(candles);
            Console.WriteLine($"The highest number of candles is : {maxNumberOfcandles}" );
        }
    }
}