namespace DrawingBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bookLengt = 12;
            int page = 7;
            var book = DrawingBook(bookLengt, page);

            Console.WriteLine(book);
        }

        static int DrawingBook(int n, int p)
        {
            var bookPage = new Dictionary<int, List<int>>();
            int numberPage  = 0;
            int numberOfPage = 0;
            for(int i = 0; i <= n / 2; i++ )
            {
                bookPage[i] = [numberPage,  ++numberPage];
                numberPage++;

                if (bookPage[i].Contains(p))
                {
                    numberOfPage = i;
                    break;
                }
                if(numberPage == p)
                {
                    numberOfPage = i + 1;
                    break;
                }
            }

            return Math.Min(numberOfPage, (n / 2) - numberOfPage);
        }
    }
}
