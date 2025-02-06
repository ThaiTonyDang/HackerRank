namespace DayoftheProgrammer
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }

        public static string dayOfProgrammer(int year)
        {
            if (year == 1918)
            {
                return "26.09.1918";
            }
            else if (IsLeapYearJulian(year) || IsLeapYearGregorian(year))
            {
                return $"12.09.{year}";
            }
            else
            {
                return $"13.09.{year}";
            }
        }

        private static bool IsLeapYearJulian(int year)
        {
            return year < 1918 && year % 4 == 0;
        }

        private static bool IsLeapYearGregorian(int year)
        {
            return year > 1918 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0));
        }
    }
}
