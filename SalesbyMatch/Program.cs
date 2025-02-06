namespace SalesbyMatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ar = [10, 20, 20, 10, 10, 30, 50, 10, 20];
            int n = 7;

            var count = sockMerchant(n, ar);

            Console.WriteLine(count);
        }

        public static int SockMerchant(int n, List<int> ar)
        {
            int count = 0;
            Dictionary<int, int> pilesPairedByColor = new Dictionary<int, int>();

            foreach(var color in ar)
            {
                if(pilesPairedByColor.ContainsKey(color))
                {
                    pilesPairedByColor[color]++;
                }
                else
                {
                    pilesPairedByColor[color] = 1;
                }
            }

            foreach(var pile in pilesPairedByColor)
            {
                if (pile.Value > 2)
                {
                    count += pile.Value / 2;
                }
            }

            return count;
        }

        public static int sockMerchant(int n, List<int> ar)
        {
            HashSet<int> colors = new HashSet<int>();
            int count = 0;

            foreach(var color in ar)
            {
                if (!colors.Add(color))
                {
                    count++;
                    colors.Remove(color);
                }
            }

            return count;
        }
    }
}
