namespace BillDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bill = new List<int> { 21, 2, 89, 94, 33, 45, 86, 22, 24, 60 };
            int k = 8;
            int b = 226;

            bonAppetit(bill, k, b) ;
        }

        public static void bonAppetit(List<int> bill, int k, int b)
        {
            var sumBill = (bill.Sum() - bill[k]) / 2;

            if (sumBill == b)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(b - sumBill);
            }

        }
    }
}
