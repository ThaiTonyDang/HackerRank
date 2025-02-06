namespace ElectronicsShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] keyboards = [60, 40, 50];
            int[] drives = [12, 9, 5, 8];
            getMoneySpent(keyboards, drives, 60);
        }

        //static int getMoneySpent(int[] keyboards, int[] drives, int b)
        //{
        //    Array.Sort(keyboards);
        //    Array.Sort(drives);
        //    Array.Reverse(keyboards);
        //    int maxCost = -1;
        //    for (int i = 0; i < keyboards.Length; i++)
        //    {
        //        for (int j = 0; j < drives.Length; j++)
        //        {
        //            int cost = keyboards[i] + drives[j];

        //            if (cost > b)
        //                break;

        //            if (cost > maxCost)
        //                maxCost = cost;
        //        }
        //    }

        //    return maxCost;
        //}

        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            Array.Sort(keyboards); 
            Array.Sort(drives);  
            Array.Reverse(drives); 

            int maxCost = -1; 
            int i = 0, j = 0;

            while (i < keyboards.Length && j < drives.Length)
            {
                int currentCost = keyboards[i] + drives[j];

                if (currentCost <= b)
                {
                    maxCost = Math.Max(maxCost, currentCost);
                    i++;
                }
                else
                {
                    j++;
                }
            }

            return maxCost;
        }
    }
}
