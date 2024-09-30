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
            // applesAndOranges();
            // betweenTwoSets();
            // breakingTheRecords();
            // subarrayDivision();
            // divisibleSumPairs();
            // fizzBuzz();
            // usernameChanges();
            longestSubarray();
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
                Console.WriteLine("Test failed!");
            }
        }

        private static void betweenTwoSets()
        {
            List<int> a = new List<int> { 2, 6 };
            List<int> b = new List<int> { 24, 36 };

            int output = BetweenTwoSets.getTotalX(a, b);

            if (output == 2)
            {
                Console.WriteLine("Test passed!");
            }
            else
            {
                Console.WriteLine("Test failed!");
            }
        }

        private static void applesAndOranges()
        {
            int s = 7, t = 10, a = 4, b = 12;

            List<int> apples = new List<int> { 2, 3, -4 };
            List<int> oranges = new List<int> { 3, -2, -4 };

            AppleAndOrange.countApplesAndOranges(s, t, a, b, apples, oranges);
        }

        private static void breakingTheRecords()
        {
            List<int> scores = new List<int> { 10, 5, 20, 20, 4, 5, 2, 25, 1 };
            List<int> output = BreakingTheRecords.breakingRecords(scores);

            Console.WriteLine(output[0] + " " + output[1]);

            if (output[0] == 2 && output[1] == 4)
            {
                Console.WriteLine("Test passed!");
            }
            else
            {
                Console.WriteLine("Test fail!");
            }
        }

        private static void subarrayDivision()
        {
            List<int> s = new List<int> { 2, 2, 1, 3, 2 };
            int d = 4;
            int m = 2;

            int output = SubarrayDivision.birthday(s, d, m);

            if (output == 2)
            {
                Console.WriteLine("Test passed!");
            }
            else
            {
                Console.WriteLine("Test fail!");
            }
        }

        private static void divisibleSumPairs()
        {
            List<int> ar = new List<int> { 1, 2, 3, 4, 5, 6 };
            int n = 6;
            int k = 5;

            int output = DivisibleSumPairs.divisibleSumPairs(n, k, ar);
            Console.WriteLine(output);

            if (output == 3)
            {
                Console.WriteLine("Test passed!");
            }
            else
            {
                Console.WriteLine("Test failed!");
            }
        }

        private static void fizzBuzz()
        {
            FizzBuzz.fizzBuzz(15);
        }

        private static void usernameChanges()
        {
            List<string> usernames = new List<string> { "foo", "bar", "baz" };
            List<string> results = UsernameChanges.possibleChanges(usernames);

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        private static void longestSubarray()
        {
            List<int> arr = new List<int> { 1, 2, 2, 3, 4, 2, 2, 3, 3 };

            int output = LongestSubarray.longestSubarray(arr);
            Console.WriteLine(output);
        }
    }
}
