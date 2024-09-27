using System;
using HackerRankAlgorithms.Algorithms;

namespace HackerRankAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // birthdayCakeCandlesTest();
            // timeConversionTest();
            // gradingStudents();
            // numberLineJumps();
            applesAndOranges();
        }

        private static void birthdayCakeCandlesTest()
        {
            Console.WriteLine("Running BirthdayCakeCandles:");

            List<int> candles = new List<int> { 3, 2, 1, 3 };

            int output = BirthdayCakeCandles.birthdayCakeCandles(candles);

            if (output == 2)
            {
                Console.WriteLine("Test passed!");
            }
            else
            {
                Console.WriteLine("Test failed!");
            }
        }

        private static void timeConversionTest()
        {
            Console.WriteLine("Running TimeConversion:");

            string input = "07:05:45PM";

            string output = TimeConversion.timeConversion(input);

            if (output == "19:05:45")
            {
                Console.WriteLine("Test passed!");
            }
            else
            {
                Console.WriteLine("Test failed!");
            }
        }

        private static void gradingStudents()
        {
            Console.WriteLine("Running Grading Students");

            List<int> input = new List<int> { 73, 67, 38, 33 };

            List<int> output = GradingStudents.gradingStudents(input);

            if (output.SequenceEqual(new List<int> { 75, 67, 40, 33 }))
            {
                Console.WriteLine("Test passed!");
            }
            else
            {
                Console.WriteLine("Test failed!");
            }
        }

        private static void numberLineJumps()
        {
            int x1 = 0, x2 = 4, v1 = 3, v2 = 2;

            string output = NumberLineJumps.kangaroo(x1, v1, x2, v2);

            if (output == "YES")
            {
                Console.WriteLine("Test passed!");
            }
            else
            {
                Console.WriteLine("Test passed!");
            }
        }

        private static void applesAndOranges()
        {
            int s = 7, t = 10, a = 4, b = 12;
            
            List<int> apples = new List<int> { 2, 3, -4 };
            List<int> oranges = new List<int> { 3, -2, -4 };

            AppleAndOrange.countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}
