public class LongestSubarray
{
    public static int longestSubarray(List<int> arr)
    {
        Dictionary<int, int> freqMap = new Dictionary<int, int>();
        int left = 0, maxLength = 0;

        for (int right = 0; right < arr.Count; right++)
        {
            if (!freqMap.ContainsKey(arr[right]))
            {
                freqMap[arr[right]] = 0;
            }
            freqMap[arr[right]]++;

            while (freqMap.Count > 2 || (freqMap.Count == 2 && Math.Abs(freqMap.Keys.ElementAt(0) - freqMap.Keys.ElementAt(1)) > 1))
            {
                freqMap[arr[left]]--;
                if (freqMap[arr[left]] == 0)
                {
                    freqMap.Remove(arr[left]);
                }
                left++;
            }

            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;

    }
}