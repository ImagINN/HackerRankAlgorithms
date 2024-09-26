namespace HackerRankAlgorithms.Algorithms
{
    public class NumberLineJumps
    {
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            string result = "";

            for (int i = 0; i < 10000; i++)
            {
                if ((x1 + v1) == (x2 + v2))
                {
                    result = "YES";
                    break;
                }
                else
                {
                    result = "NO";
                }
                Console.WriteLine(result);
            }

            return result;
        }
    }
}