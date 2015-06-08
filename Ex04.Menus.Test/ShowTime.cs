using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    class ShowTime : Interfaces.IExecutableItem
    {
        public void runCommand()
        {
            Console.WriteLine("The clock shows: {0}", timeRightNow());
            Console.WriteLine("Press any key to quit");
            Console.ReadLine();
        }

        private string timeRightNow()
        {
            return DateTime.Now.ToShortTimeString();
        }
    }
}
