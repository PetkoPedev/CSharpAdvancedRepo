﻿using System;
using System.IO;
using System.Linq;

namespace P01_EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFilePath = @"..\..\..\text.txt";
            int counter = 0;

            using (StreamReader streamReader = new StreamReader(textFilePath))
            {
                string currentLine = streamReader.ReadLine();

                while (currentLine != null)
                {
                    if (counter % 2 == 0)
                    {
                        string replacedSymbols = ReplaceSpecialCharacters(currentLine);
                        string reversedWords = ReversedWords(replacedSymbols);

                        Console.WriteLine(reversedWords);
                    }

                    currentLine = streamReader.ReadLine();

                    counter++;
                }
            }
        }

        private static string ReversedWords(string replacedSymbols)
        {
            return string.Join(" ", replacedSymbols.Split().Reverse());
            
        }

        private static string ReplaceSpecialCharacters(string currentLine)
        {
            //{"-", ",", ".", "!", "?"}
            return currentLine.Replace("-", "@")
                .Replace(",", "@")
                .Replace(".", "@")
                .Replace("!", "@")
                .Replace("@", "@");
        }
    }
}
