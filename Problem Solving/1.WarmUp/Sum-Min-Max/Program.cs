using System;
using System.Linq;

namespace Sum_Min_Max
{
    // Tìm tổn min , max n-1 phần tử trong mảng arr n phần tử
    // Ví dụ 1 2 3 4 5
    // sum min = 1 + 2 + 3 + 4
    // sum max = 2 + 3 + 4 + 5

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 2, 3, 5, 1, 4 };
            int sumMin = 0, sumMax = 0, Sum = 0;
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                Sum += arr[i];
                if (max < arr[i])
                {
                    max = arr[i];
                }
                if (min > arr[i])
                {
                    min = arr[i];
                }

            }
            sumMax = Sum - min;
            sumMin = Sum - max;
            Console.WriteLine("{0} {1}", sumMin, sumMax);
        }
    
    }
}