using System;
using System.Collections.Generic;
using System.Linq;

namespace MathPuzzles
{
    public class Program1 : IProgram
    {
        public void Run(IEnumerable<string> arguments)
        {
            Console.WriteLine(GetAnswer());
        }

        public static int GetAnswer()
        {
            return GetOddNumbers(10).First(IsPalindrome);
        }

        private static bool IsPalindrome(int number)
        {
            return IsDecimalPalindrome(number) && IsBinaryPalindrome(number) && IsOctalPalindrome(number);
        }

        private static bool IsOctalPalindrome(int number)
        {
            var oct = Convert.ToString(number, 8);
            return IsPalindrome(oct);
        }

        private static bool IsBinaryPalindrome(int number)
        {
            var bin = Convert.ToString(number, 2);
            return IsPalindrome(bin);
        }

        private static bool IsDecimalPalindrome(int number)
        {
            var dec = number.ToString();
            return IsPalindrome(dec);
        }

        private static bool IsPalindrome(string str)
        {
            return str.SequenceEqual(str.Reverse());
        }

        private static IEnumerable<int> GetOddNumbers(int start)
        {
            var first = start % 2 == 0 ? start + 1 : start;
            for (var i = first; i < int.MaxValue; i += 2)
            {
                yield return i;
            }
        }
    }
}