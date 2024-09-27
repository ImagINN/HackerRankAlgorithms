namespace HackerRankAlgorithms.Algorithms
{
    public class BetweenTwoSets
    {
        public static int getTotalX(List<int> a, List<int> b)
        {
            int maxA = a.Max();
            int minB = b.Min();
            int count = 0;

            for (int x = maxA; x <= minB; x++)
            {
                bool isFactorOfA = a.All(ai => x % ai == 0);

                bool isFactorOfB = b.All(bi => bi % x == 0);

                if (isFactorOfA && isFactorOfB)
                {
                    count++;
                }
            }

            return count;
        }
    }
}