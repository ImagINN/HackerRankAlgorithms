namespace HackerRankAlgorithms.Algorithms
{
    public class AppleAndOrange
    {
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int howManyAppleSamHave = 0, howManyOrangeSamHave = 0;

            List<int> applesFallingPlaces = new List<int> { };
            List<int> orangesFallingPlaces = new List<int> { };

            foreach (int location in apples)
            {
                applesFallingPlaces.Add(a + location);
            }

            foreach (int location in oranges)
            {
                orangesFallingPlaces.Add(b + location);
            }

            foreach (var location in applesFallingPlaces)
            {
                if (location >= s && location <= t)
                {
                    howManyAppleSamHave++;
                }
            }

            foreach (var location in orangesFallingPlaces)
            {
                if (location >= s && location <= t)
                {
                    howManyOrangeSamHave++;
                }
            }

            Console.WriteLine(howManyAppleSamHave);
            Console.WriteLine(howManyOrangeSamHave);
        }
    }
}