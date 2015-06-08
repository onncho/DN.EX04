using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    class DelegateTestDateAndTime
    {
        public string getStringOfTime()
        {
            string header = "The time is: " + DateTime.Now.ToString("h:mm:ss tt");
            string endLine = "\n------ Press any key to finish -------";
            string formatted = header + endLine;
            return formatted;
        }
        public void printTimeFromString()
        {
            string timeToPrint = getStringOfTime();
            Console.WriteLine(timeToPrint);
            Console.ReadLine();
        }

        public string getStringOfDate()
        {
            string header = "The time is: " + DateTime.Now.ToString("M/d/yyyy");
            string endLine = "\n------ Press any key to finish -------";
            string formatted = header + endLine;
            return formatted;
        }
        public void printDateFromString()
        {
            string dateToPrint = getStringOfDate();
            Console.WriteLine(dateToPrint);
            Console.ReadLine();
        }
    }
}
