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
            while (inputString.Contains("  "))
            {
                inputString = space.Replace(inputString, " ");
            }

            inputString = Regex.Replace(inputString, "[-.?!)(,:;'[0-9\\]]", "");
            string[] wordsString = inputString.Split(" ");
            int maxLength = wordsString[0].Length;
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