using System;

namespace Diagonal_Difference
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input column and row number :");
            int n = Int32.Parse(Console.ReadLine());


            int[,] arr = new int[n, n] ;

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ");
                for (int j = 0; j < n; j++)
                {                   
                    arr[i, j] = Int32.Parse(tokens[j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" " + arr[i, j]);
                }
                Console.WriteLine();
            }

            int result = Diagonal_Diff(arr);

            Console.WriteLine($"result : {result}" );
        }

        public static int Diagonal_Diff(int[,] arr)
        {
            int sumRigh = 0;
            int sumLeft = 0;
            int rowNumber = 3;
            for (int i = 0; i < rowNumber; i++)
            {
                sumLeft += arr[i, i];
                sumRigh += arr[i, rowNumber - 1 - i];
            }
            return Math.Abs(sumLeft - sumRigh);
        }
    }
}
