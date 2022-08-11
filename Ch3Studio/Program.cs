using System;

namespace Ch3Studio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringToCount;

            Console.WriteLine("Enter a string: ");
            stringToCount = Console.ReadLine().ToUpper();

            Dictionary<char, int> charCount = new Dictionary<char, int>();
            char[] charactersInString = stringToCount.ToCharArray();

            foreach (char character in charactersInString)
            {
                if (charCount.ContainsKey(character))
                {
                    charCount[character]++;
                } else
                {
                    charCount.Add(character, 1);
                }
            }

            foreach (KeyValuePair<char, int> count in charCount)
            {
                Console.WriteLine($"{count.Key}: {count.Value}\n");
            }

        }
    }
}