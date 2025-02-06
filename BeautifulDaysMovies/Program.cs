using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BeautifulDaysMovies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 20;

            int j = 23;

            int k = 6;

            int result = BeautifulDays(i, j, k);

            Console.WriteLine(result);
        }

        public static int BeautifulDays(int i, int j, int k)
        {
            int count = 0;
            for (int start = i; start <= j; start++)
            {
                var diff = Math.Abs(start - IntegerReverseRecursive(start));
                if (diff % k == 0)
                {
                    count++;
                }
            }

            return count;
        }

        //public static int IntegerReverse(int i)
        //{
        //    var reverse = i.ToString().Reverse().ToArray();

        //    return Int32.Parse(reverse);
        //}

        public static int IntegerReverse(int number)
        {
            int reversed = 0;
            while (number > 0)
            {
                var digit = number % 10;
                reversed = reversed * 10 + digit;
                number /= 10;
            }

            return reversed;
        }

        public static int IntegerReverseRecursive(int number)
        {
            return ReverseHelper(number, 0);
        }

        private static int ReverseHelper(int number, int reversed)
        {
            if (number == 0)
            {
                return reversed;
            }

            var reHelper = ReverseHelper(number /10, reversed * 10 + number % 10);
            return reHelper;
        }
    }
}
