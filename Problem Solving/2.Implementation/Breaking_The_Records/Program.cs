using System;
using System.Collections.Generic;

namespace Breaking_The_Records
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var scores = new List<int>() { 12, 24, 10, 24 };
            var scores_2 = new List<int>() { 10, 5, 20, 20, 4, 5, 2, 25, 1 };

            breakingRecords(scores).ForEach(result => Console.Write(" " + result ));

            breakingRecords(scores_2).ForEach(result => Console.Write(" " + result));
        }

        public static List<int> breakingRecords(List<int> scores)
        {
            List<int> result = new List<int>();
            int low = scores[0];
            int high = scores[0];

            int minScore = 0;
            int maxScore = 0;

            for (int i = 0; i < scores.Count; i++)
            {
                if (scores[i] > high)
                {
                    maxScore++;
                    high = scores[i];
                    
                }

                if (scores[i] < low)
                {
                    minScore++;
                    low = scores[i];
                   
                }

            }
            result.Add(maxScore);
            result.Add(minScore);

            return result;
        }
    }
}
