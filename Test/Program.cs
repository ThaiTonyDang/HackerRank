using System.Diagnostics;
using System.Management;
using System.Text;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Practise("Hello ! Noah Dang Tran Thai"));
            Console.WriteLine(GCD(60, 36));
        }

        public static string Distinct(string s)
        {
            var stringBuilder = new StringBuilder();
            // Add char vaof trong stringBuilder bang Append, kiem tra Index cua ky tu do trong StringBuilder , neu ki tu chua ton tai nghia laf index = -1 thi Tiếp tục Append vào stringbuiler
            for (int i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];
                if (stringBuilder.ToString().IndexOf(currentChar) == -1)
                {
                    stringBuilder.Append(currentChar);
                }
            }

            return stringBuilder.ToString();
        }

        public static string Practise(string s)
        {
            StringBuilder stringBuilder = new();
            for (int i = 0; i < s.Length; i++)
            {
                if (stringBuilder.ToString().IndexOf(s[i]) == -1)
                {
                    stringBuilder.Append(s[i]);
                }
            }

            return stringBuilder.ToString();
        }

        public static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return b;
            }

            return GCD(b, a % b);
        }
    }
}
