using System;

namespace AlphabetOrder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("AlphabetOrder.Program.Main()");
            Console.WriteLine(ToAlpha("Today is the thirteenth of Feburary"));
        }
        public static string ToAlpha(string input)
        {
            input = input.ToLower();
            string output = "";
            for (int i = 'a'; i <= 'z'; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == i)
                    {
                        output += input[j];
                        break;
                    }
                }
            }
            return output;
        }
    }
}
