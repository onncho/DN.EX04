using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    public class InterfaceMenueTest
    {
        MainMenu m_menu;

        public InterfaceMenueTest()
        {
             //info menu
            List<Interfaces.MenuMember> info = new List<Interfaces.MenuMember>();
            info.Add(new Interfaces.MenuMember("Show Version", new ShowVersion()));
            info.Add(new Interfaces.MenuMember("Count Words", new CountWordsFromASentece()));
            
            //date and time menu
            List<Interfaces.MenuMember> showTimeOrDate = new List<Interfaces.MenuMember>();
            showTimeOrDate.Add(new Interfaces.MenuMember("Show Date", new ShowDate()));
            showTimeOrDate.Add(new Interfaces.MenuMember("Show Time", new ShowTime()));

            //main menu
            List<Interfaces.MenuMember> mainMenu = new List<Interfaces.MenuMember>();
            mainMenu.Add(new Interfaces.MenuMember(showTimeOrDate, "Show Date / Time"));
            mainMenu.Add(new Interfaces.MenuMember(info, "Info"));

            m_menu = new MainMenu(mainMenu);
        }

        public void showMenu()
        {
           m_menu.show();
        }
    }
}
