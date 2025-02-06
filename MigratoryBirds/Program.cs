namespace MigratoryBirds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 1, 1, 2, 2, 3, 3, 3, 4, 5, 6, 6, 7, 8, 8, 8 };

            int result = MigratoryBirds(arr);
            Console.WriteLine(result); // Output sẽ là 3 (vì ID 3 xuất hiện nhiều nhất)
        }

        public static int MigratoryBirds(List<int> arr)
        {
            Dictionary<int, int> birdCount = new Dictionary<int, int>();

            foreach (int birdId in arr)
            {
                if (birdCount.ContainsKey(birdId))
                {
                    birdCount[birdId]++;
                }
                else
                {
                    birdCount[birdId] = 1;
                }
            }

            int maxCount = 0;
            int result = int.MaxValue; 

            foreach (var bird in birdCount)
            {
                if (bird.Value > maxCount)
                {
                    maxCount = bird.Value;
                    result = bird.Key;
                }
                else if (bird.Value == maxCount && bird.Key < result)
                {
                    result = bird.Key;
                }
            }

            return result;
        }
    }
}
