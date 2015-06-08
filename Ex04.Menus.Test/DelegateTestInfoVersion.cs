using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Ex04.Menus.Test
{
    class DelegateTestInfoVersion
    {
        private string generateVersionString()
        {
            string versionNumber = "Version: 15.2.4.0";
            string endLine = "\n------ Press any key to finish -------";
            string formatted = versionNumber + endLine;
            return formatted;
        }
        public void printVersionFromString()
        {
            string versionNumberString = generateVersionString();
            Console.WriteLine(versionNumberString);
            Console.ReadLine();
        }

        private string generateCountWordsString()
        {
            string header = "Please enter a sentence to check his word-count : ";
            Console.WriteLine(header);
            return Console.ReadLine();
        }

        public void printCountWordsFromString()
        {
            string input = generateCountWordsString();
            string endLine = "\n------ Press any key to finish -------";
            int amountOfWords = Regex.Matches(input, @"[A-Za-z0-9']+").Count;
            Console.WriteLine("The Amount of words in the sentence is : " + amountOfWords);
            Console.WriteLine(endLine);
            Console.ReadLine();

        }
    }
}
