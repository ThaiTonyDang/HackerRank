namespace ClimbingLeaderboard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ranked = [100, 100, 95, 78, 65, 50, 40, 40, 20, 10];
            List<int> player = [5, 25, 50, 60, 72, 80, 90, 99, 120];

            var climbingLeaderboard = ClimbingLeaderboard(ranked, player);

            // 102, 100, 90, 80, 77 , 75, 65, 60, 50

            // tra ve [9, 7, 5, 3, 1]

            climbingLeaderboard.ForEach(leaderboard => { Console.Write( " " +leaderboard); });
        }

        public static List<int> ClimbingLeaderboard(List<int> ranked, List<int> player)
        {
            List<int> distincRanked = new();
            if (ranked.Count > 0)
            {
                distincRanked.Add(ranked[0]);
                for (int i = 1; i < ranked.Count; i++)
                {
                    if (ranked[i] != ranked[i - 1])
                    {
                        distincRanked.Add(ranked[i]);
                    }
                }
            }

            List<int> result = new();
            var index = distincRanked.Count - 1;

            foreach (int p in player)
            {
                while (index >= 0 && p >= distincRanked[index])
                {
                    index--;
                }

                result.Add((index + 1) + 1);
            }

            return result;
        }
    }
}
