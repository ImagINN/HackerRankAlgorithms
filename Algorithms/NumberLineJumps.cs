namespace HackerRankAlgorithms.Algorithms
{
    public class NumberLineJumps
    {
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v1 == v2 && x1 != x2)
            {
                return "NO";
            }
            else if ((x1 < x2 && v1 <= v2) || (x2 < x1 && v2 <= v1))
            {
                return "NO";
            }
            else
            {
                if ((x2 - x1) % (v1 - v2) == 0)
                {
                    return "YES";
                }
                else
                {
                    return "NO";
                }
            }
        }

    }
}