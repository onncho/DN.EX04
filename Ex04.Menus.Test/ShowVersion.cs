using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    public class ShowVersion : Interfaces.IExecutableItem
    {
        public void runCommand()
        {
            Console.WriteLine("Version: 15.2.4.0");
            Console.WriteLine("Press any key to quit");
            Console.ReadLine();
        }
    }
}
