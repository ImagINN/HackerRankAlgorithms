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
    }
}
