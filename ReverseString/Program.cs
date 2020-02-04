using System;

namespace ReverseString
{
    public class Program
    {
        static void Main(string[] args)
        {
            string testString = "Josh";
            Console.WriteLine(GetReverse(testString)); 
        }
        public static string GetReverse (string input)
        {
            string output = "";
            for (int i = 1; i <= input.Length; i++)
            {
                output += input[input.Length - i];
            }

            return output;
        }
    }
}
