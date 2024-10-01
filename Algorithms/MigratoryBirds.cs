public class MigratoryBirds
{
    public static int migratoryBirds(List<int> arr)
    {
        Dictionary<int, int> birdCounts = new Dictionary<int, int>();

        foreach (int bird in arr)
        {
            if (birdCounts.ContainsKey(bird))
            {
                birdCounts[bird]++;
            }
            else
            {
                birdCounts[bird] = 1;
            }
        }

        int maxCount = birdCounts.Values.Max();

        var mostFrequentBirds = birdCounts.Where(b => b.Value == maxCount).Select(b => b.Key);

        return mostFrequentBirds.Min();
    }
}