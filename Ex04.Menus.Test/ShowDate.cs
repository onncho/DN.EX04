using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    class ShowDate : Interfaces.IExecutableItem
    {
        public void runCommand()
        {
            Console.WriteLine("Today's Date: {0}", todayDate());
            Console.WriteLine("Press any key to quit");
            Console.ReadLine();
        }

        private string todayDate()
        {
            return DateTime.Now.ToShortDateString();
        }
    }
}
