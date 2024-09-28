namespace HackerRankAlgorithms.Algorithms
{
    public class SubarrayDivision
    {
        public static int birthday(List<int> s, int d, int m)
        {
            int ways = 0;

            for (int i = 0; i <= s.Count - m; i++)
            {
                int birthdaySum = 0;

                for (int j = 0; j < m; j++)
                {
                    birthdaySum += s[i + j];
                }

                if (birthdaySum == d)
                {
                    ways++;
                }
            }

            return ways;
        }

    }
}