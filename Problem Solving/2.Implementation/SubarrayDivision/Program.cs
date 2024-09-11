namespace SubarrayDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> cl = [2, 2, 1, 3, 1, 1, 2, 2, 1, 4, 0, 2, 3, 5];
            int day = 5;
            int month = 3;

            var result = birthday(cl, day, month);

            Console.WriteLine("Số lượng mảng con thỏa mãn: " + result.Item1);
            Console.WriteLine("Các mảng con thỏa mãn:");

            foreach (var subarray in result.Item2)
            {
                Console.WriteLine(string.Join(", ", subarray));
            }
        }

        public static int Birthday(List<int> cl, int d, int m)
        {
            int count = 0;
            List<List<int>> validSubarrays = new List<List<int>>();
            for (int i = 0; i < cl.Count; i++)
            {
                int sum = 0;
                var edge = i + m - 1;

                for (int k = i; k <= edge && edge < cl.Count ; k++)
                {
                    sum += cl[k];
                    if (sum == d && k - i + 1 == m) // điều kiện tổng và tổng đó phải được cộng bởi m số
                    {
                        count++;
                    }
                }
            }

            return count;

        }

        public static (int, List<List<int>>) birthday(List<int> cl, int d, int m)
        {
            int count = 0;
            List<List<int>> validSubarrays = new List<List<int>>();
            for (int i = 0; i <= cl.Count - m; i++)
            {
                int sum = 0;
                List<int> currentSubarray = new List<int>();
                for (int k = i; k < i + m; k++)
                {
                    sum += cl[k];
                    currentSubarray.Add(cl[k]);
                }
                if (sum == d)
                {
                    count++;
                    validSubarrays.Add(currentSubarray);
                }
            }

            return (count, validSubarrays);
        }

    }
}
