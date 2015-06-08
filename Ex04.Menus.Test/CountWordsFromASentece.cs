using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Ex04.Menus.Test
{
    class CountWordsFromASentece : Interfaces.IExecutableItem
    {
        public void runCommand()
        {
            Console.WriteLine("This tool count words from a sentence, please insert a string and press enter");
            string userInput = Console.ReadLine();
            
            Console.WriteLine("We Count : {0} words", CountWordsFromString(userInput));
            Console.WriteLine("Press any key to quit");
            Console.ReadLine();
        }

        private int CountWordsFromString(string userInput)
        {
            MatchCollection collection = Regex.Matches(userInput, @"[\S]+");
            return collection.Count;
        }
    }
}
