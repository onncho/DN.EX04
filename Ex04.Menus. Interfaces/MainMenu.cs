using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    class MainMenu : Menu
    {

        //private string m_MenuTitle;
        //private List<T> m_MenuList = new List<T>();
        //private m_UserMsg = "Please Chosse one of the following options or Exit (pick a number)";

        //
        //MenuItem mymenuItem = new MenueItem(bool isExe, string optionTitle);
        // members : List menue, execute() : 1. create new menue
        // 2. run function.

        private List<MenuItem> m_MenueList;
        private string m_UserMsg = "Please Chosse one of the following options or Exit (pick a number)";
        private string m_MenueTitle;

        public MainMenu(string i_menueTitle)
        {
            m_MenueList = new List<MenuItem>();
            m_MenueTitle = i_menueTitle;
        }

        public MainMenu(string i_menueTitle, List<MenuItem> i_menueItems)
        {
            m_MenueList = i_menueItems;
            m_MenueTitle = i_menueTitle;
        }

        
        public void addItemToMenu(MenuItem i_menuItemToAdd)
        {
            m_MenueList.Add(i_menuItemToAdd);
        }

        public void showMenu()
        {
            throw new NotImplementedException();
        }

        public void exit()
        {
            throw new NotImplementedException();
        }

        public void run()
        {
            throw new NotImplementedException();
        }

        public int readInputFromUser()
        {
            throw new NotImplementedException();
        }

        public void mapInputToChoice(int i_choice)
        {
            throw new NotImplementedException();
        }
    }
}
