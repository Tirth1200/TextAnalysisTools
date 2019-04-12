using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnalysisTools
{
    class Program
    {
        static void Main(string[] args) {
            Program a = new Program();
            Console.WriteLine("the longest word is : ");
             Console.WriteLine(a.MyFunctionA("Ada Lovelace wrote the first algorithm designed for processing by an Analytical Engine."));
        }

        public String MyFunctionA(string input)
        {
            // Write a C# program to find the longest word in a string.
            string[] words = input.Split(' ');

            int wordArrayLength = words.Length;
            int[] wordsLength = new int[wordArrayLength];

            foreach (var word in words)
            {
                // TODO
            }
            // loop post condition: we now have array word Length which
            // contains the lengths of each word

            string currentWord = words[0];
            string nextWord;

            for (int y = 0; y < words.Length - 1; y++)
            {
                currentWord = words[y];
                nextWord = words[y + 1];
                // TODO: Use an IF Statement to make sure that variable longest Word
                // is always set to the Longest Word in the input string
            }
            return currentWord;
        }
        
    }
}
