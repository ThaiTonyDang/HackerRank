using System;
using System.Collections.Generic;
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
            List<int> arr = [156873294, 719583602, 581240736, 605827319, 895647130];
            long sum = arr.Sum();
            var min = arr[0];
            var max = arr[0];
            for (int i = 0; i <= arr.Count() - 1; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine($"{sum - max} {sum - min}");
        }
    
    }
}