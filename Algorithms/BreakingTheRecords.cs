namespace HackerRankAlgorithms.Algorithms
{
    public class BreakingTheRecords
    {
        public static List<int> breakingRecords(List<int> scores)
        {
            if (scores == null || scores.Count == 0)
                throw new ArgumentException("Scores list cannot be null or empty");

            int minScore = scores[0];
            int maxScore = scores[0];
            int minCount = 0;
            int maxCount = 0;

            for (int i = 1; i < scores.Count; i++)
            {
                int currentScore = scores[i];

                if (currentScore < minScore)
                {
                    minScore = currentScore;
                    minCount++;
                }
                else if (currentScore > maxScore)
                {
                    maxScore = currentScore;
                    maxCount++;
                }
            }

            return new List<int> { maxCount, minCount };
        }

    }
}