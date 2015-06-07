using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public interface IMenu
    {
        void showMenu();
        void exit();
        string getTitle();
        //
        //void run();

        // read input from user
        int readInputFromUser();

        // input user to invoke function
        //void mapInputToChoice(int i_choice);
    }
}
