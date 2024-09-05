using System;

namespace Plus_Minus_radio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the Array's length :");
            int length = Int32.Parse(Console.ReadLine());
            int[] arr = new int[length];
            Console.WriteLine("Input array 's element");
            for (int i = 0; i < length; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            double[] rad = radios(arr);
            PrintArray(rad);
        }

        public static double[] radios(int[] arr)
        {
            double[] plusMinus = new double[3];
            int length = arr.Length;
            int positive = 0;
            int negative = 0;
            int zeros = 0;
            for (int i = 0; i < length; i++)
            {
                if (arr[i] > 0)
                {
                    positive++;
                 
                }
                if (arr[i] < 0)
                {
                    negative++;
                }
                if (arr[i] == 0)
                { 
                    zeros++;
                }
                
            }

            plusMinus[0] = Math.Round((double) positive / length, 6);
            plusMinus[1] = Math.Round((double) negative  / length , 6);
            plusMinus[2] = Math.Round((double)zeros / length , 6);
            return plusMinus;
        }

        public static void PrintArray( double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("  " + array[i]);
            }
        }
    }
}
