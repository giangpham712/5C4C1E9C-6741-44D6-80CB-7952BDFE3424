using System;
using System.Linq;

namespace Kmart.CodingTest.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var longestIncreasingSubsequence = FindLongestIncreasingSubsequence(string.Join(' ', args));
            Console.WriteLine(longestIncreasingSubsequence);
        }

        public static string FindLongestIncreasingSubsequence(string input)
        {
            if (input == string.Empty)
            {
                return string.Empty;
            }

            var values = input.Split(' ').Select(long.Parse).ToArray();

            var longest = 1;
            var longestStartIndex = 0;
            var currentStartIndex = 0;
            for (var i = 1; i <= values.Length; i++)
            {
                if (i < values.Length && values[i] > values[i - 1])
                {
                    continue;
                }

                if (i - currentStartIndex > longest)
                {
                    longest = i - currentStartIndex;
                    longestStartIndex = currentStartIndex;
                }

                currentStartIndex = i;
            }

            return string.Join(' ', values.Skip(longestStartIndex).Take(longest));
        }
    }
}
