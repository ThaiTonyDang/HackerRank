using System;

namespace StairCase
{
    internal class Program
    {
        /*       #
                ##
               ###
              ####
             #####
            ######
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Input staircase number :");
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            staircase(n);
        }

        public static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
      
    }
}