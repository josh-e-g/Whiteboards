using System;

namespace Palindrome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("Racecare"));
        }
        public static bool IsPalindrome(string input)
        {
            input = input.ToLower();
            string output = "";
            bool result = false;
        
            for (int i = 1; i <= input.Length; i++)
            {
                output += input[input.Length - i];
            }
            if (input == output)
            {
                result = true;
            }
            return result;
        }
    }
}
