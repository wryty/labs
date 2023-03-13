using System;
using System.Text.RegularExpressions;
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex space = new Regex("  ");

            string inputString = "hello,        how.     are you! longword";
            while (true)
            {
                if (inputString.Contains("  "))
                {
                    inputString = space.Replace(inputString, " ");
                }
                else { break; }
            } // можно так

            inputString = Regex.Replace(inputString, "[-.?!)(,:;'[0-9\\]]", ""); // или так
            string[] wordsString = inputString.Split(" ");
            int maxLength = -1;
            string maxLengthWord = "";
            for (int i = 0; i < wordsString.Length; i++)
            {
                if (wordsString[i].Length > maxLength)
                {
                    maxLength = wordsString[i].Length;
                    maxLengthWord = wordsString[i];
                }
            }

            Console.WriteLine(maxLengthWord);

        }
    }
}