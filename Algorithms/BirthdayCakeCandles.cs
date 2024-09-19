namespace HackerRankAlgorithms.Algorithms
{
    public class BirthdayCakeCandles
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            int val = candles[0];
            int result = 1;

            for (int i = 1; i < candles.Count; i++)
            {
                if (candles[i] > val)
                {
                    val = candles[i];
                    result = 1;
                }
                else if (candles[i] == val)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
