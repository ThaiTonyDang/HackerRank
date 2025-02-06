namespace FormingMagicSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[][] s = new int[3][];
            //for (int i = 0; i < 3; i++)
            //{
            //    string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //    s[i] = Array.ConvertAll(tokens, int.Parse);
            //}

            // Jagged Array 
            int[][] jagged = new int[][]
            {
                new int[] {4, 9, 2},
                new int[] {3, 5, 7},
                new int[] {8, 1, 5}
            };

            int[,] rectagular = new int[,]
            {
                {4, 9, 2},
                {3, 5, 7},
                {8, 1, 5}
            };

            int result = FormingMagicSquare(rectagular);
            Console.WriteLine(result);
        }

        public static int FormingMagicSquare(int[,] s)
        {
            // Jagged Array 
            int[][][] jaggedMagicSquares = new int[][][]
            {
                new int[][] { new int[] {8, 1, 6}, new int[] {3, 5, 7}, new int[] {4, 9, 2} },
                new int[][] { new int[] {6, 1, 8}, new int[] {7, 5, 3}, new int[] {2, 9, 4} },
                new int[][] { new int[] {4, 9, 2}, new int[] {3, 5, 7}, new int[] {8, 1, 6} },
                new int[][] { new int[] {2, 9, 4}, new int[] {7, 5, 3}, new int[] {6, 1, 8} },
                new int[][] { new int[] {8, 3, 4}, new int[] {1, 5, 9}, new int[] {6, 7, 2} },
                new int[][] { new int[] {4, 3, 8}, new int[] {9, 5, 1}, new int[] {2, 7, 6} },
                new int[][] { new int[] {6, 7, 2}, new int[] {1, 5, 9}, new int[] {8, 3, 4} },
                new int[][] { new int[] {2, 7, 6}, new int[] {9, 5, 1}, new int[] {4, 3, 8} }
            };

            int[][,] rectangMagics = new int[][,]
            {
                new int[,] { {8, 1, 6}, {3, 5, 7}, {4, 9, 2} },
                new int[,] { {6, 1, 8}, {7, 5, 3}, {2, 9, 4} },
                new int[,] { {4, 9, 2}, {3, 5, 7}, {8, 1, 6} },
                new int[,] { {2, 9, 4}, {7, 5, 3}, {6, 1, 8} },
                new int[,] { {8, 3, 4}, {1, 5, 9}, {6, 7, 2} },
                new int[,] { {4, 3, 8}, {9, 5, 1}, {2, 7, 6} },
                new int[,] { {6, 7, 2}, {1, 5, 9}, {8, 3, 4} },
                new int[,] { {2, 7, 6}, {9, 5, 1}, {4, 3, 8} }
            };

            int minCost = int.MaxValue;

            foreach (var magic in rectangMagics)
            {
                int cost = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        cost += Math.Abs(s[i,j] - magic[i,j]);
                    }
                }

                if (cost < minCost)
                {
                    minCost = cost;
                }
            }

            return minCost;
        }
    }
}
