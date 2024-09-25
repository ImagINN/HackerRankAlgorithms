namespace HackerRankAlgorithms.Algorithms
{
    public class GradingStudents
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> roundedGrades = new List<int>();

            foreach (int grade in grades)
            {
                int newGrade = roundHigher(grade);
                if (newGrade >= 40)
                {
                    roundedGrades.Add(newGrade);
                }
                else
                {
                    roundedGrades.Add(grade);
                }
            }

            return roundedGrades;
        }

        public static int roundHigher(int number)
        {
            int div = ((number / 5) + 1) * 5;

            if (div - number < 3)
            {
                return div;
            }
            else
            {
                return number;
            }
        }
    }
}