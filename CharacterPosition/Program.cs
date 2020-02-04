using System;

namespace CharacterPosition
{
    public class Program
    {
        //Write a method to find the position (not the index)
        //of the first occurence of a character in a string.
        //Return 0 if the character is not found.
        public static void Main(string[] args)
        {
            Console.WriteLine("CharacterPosition.Program.Main()");
            Console.WriteLine(GetPosition("Hello", 'z'));
        }
        public static int GetPosition(string input, char letter)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == letter) return i + 1;
            }
            return 0;
        }
    }
}
