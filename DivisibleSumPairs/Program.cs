using System.Security.Cryptography;

namespace DivisibleSumPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = [29, 97, 52, 86, 27, 89, 77, 19, 99, 96];
            List<int> list = [1, 3, 4, 6, 19, 23, 10, 7, 14, 9, 30 ,18, 5, 37];
            int n = list.Count;
            int k = 8;

            //int count = divisibleSumPairs(n, k, list);
            //int count = DivisibleSumPairs(n, k, list);
            var result = PractiseDivisible(n, k, list);

            Console.WriteLine($"The Number of pairs divisible by {k} : {result.count}");
            var index = 1;
            result.pairs.ForEach(p =>
            {

                Console.WriteLine($" Number {index}  " + p.Item1 + " " + p.Item2);

                index++;
            });
        }

        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            var count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    var sum = ar[j] + ar[i];
                    if (sum == k || sum % k == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public static int DivisibleSumPairs(int n, int k, List<int> ar)
        {
            int count = 0;
            int[] remainderFrequency = new int[k];
            foreach (int number in ar)
            {
                int remainder = number % k;
                int complement = (k - remainder) % k;
                count += remainderFrequency[complement];
                remainderFrequency[remainder]++;
            }

            return count;
        }

        public static (int count, List<(int, int)> pairs) DivisibleSumPairsWithPairs(int n, int k, List<int> ar)
        {
            var count = 0;
            List<(int, int)> resultPairs = new List<(int, int)>();
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int sum = ar[i] + ar[j];
                    if (sum % k == 0)
                    {
                        count++;
                        resultPairs.Add((ar[i], ar[j]));
                    }
                }
            }

            return (count, resultPairs);
        }

        public static (int count, List<(int, int)> pairs) DivisibleSumPairsWithPairs_Optimized(int n, int k, List<int> ar)
        {
            var count = 0;
            List<(int, int)> resultPairs = new List<(int, int)>();

            Dictionary<int, List<int>> remainderMAp = new Dictionary<int, List<int>>();
            for (int r = 0; r < k; r++)
            {
                remainderMAp[r] = new List<int>();
            }

            foreach (int number in ar)
            {
                int remainder = number % k;
                int complement = (k - remainder) % k;

                foreach (int prev in remainderMAp[complement])
                {
                    resultPairs.Add((prev, number));
                    count++;
                }

                remainderMAp[remainder].Add(number);
            }

            return (count, resultPairs);
        }

        public static (int count, List<(int, int)> pairs) PractiseDivisible(int n, int k, List<int> ar)
        {
            var count = 0;
            List<(int, int)> pairs = new();

            // Tạo một Dictionary với key là số dư của từng số trong ar, value là List các số mode cho k ra số dư đó.

            Dictionary<int, List<int>> keyValuePairs = new();
            for (int remain = 0; remain < k; remain++)
            {
                keyValuePairs[remain] = new List<int>();
            }

            foreach (var number in ar)
            {
                // xác định số dư của từng số lưu nó vô trong Dictionary
                // kiểm tra nếu trong dictionnary Key của số bù tức là số dư đã tồn tại hay có giá trị thì lưu số có giá trị bù này và số hiện tại.
                // B1 : xác định số dư của number
                var sodu = number % k;
                // B2 xác định số bù của sodu để chia hêts cho k
                var sobu = (k - sodu) % k;


                // B3 quét Dictionary nếu tại vị trí Key tức là tại vị trí có số dư là sobu tồn tại số tương ứng vừa lưu gọi là số A thì lưu cặp số A và number (vì A + number chắc chắn chia hết k)  
                // 2 % 8 = 2  ==> lưu số này ở vị trí 2 với số 2 (số A)
                // 22 % 8 = 6 ==> số bù là số 2 ==> Quet dic tại vị trí số bù 2  thi thấy có tồn tại số 2 ==> lưu số 2 với số 22 vào List ! (2 + 22 = 24 % 8 = 0) 
                // Vi du so 9 co so du laf 1, sobu = 7 , m truoc do o vi tri so du 7 co luu 2 so 23 va 7 thi no add 9, 23 va 9 , 7
                foreach (var prev in keyValuePairs[sobu])
                {
                    pairs.Add((prev, number));
                    count++;
                }

                // B4 Lưu số dư và số có số dư ấy vào Dictionary
                keyValuePairs[sodu].Add(number);

            }

            return (count, pairs);
        }
    }
}
