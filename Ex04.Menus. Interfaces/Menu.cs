using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    interface Menu
    {
        void showMenu();
        void exit();

        //
        void run();

        // read input from user
        int readInputFromUser();

        // input user to invoke function
        void mapInputToChoice(int i_choice);
    }
}
