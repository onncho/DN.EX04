using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test.MainMenu
{
    public class MainMenu : Interfaces.IMenu, Interfaces.IMenuItem
    {

        //private string m_MenuTitle;
        //private List<T> m_MenuList = new List<T>();
        //private m_UserMsg = "Please Chosse one of the following options or Exit (pick a number)";

        //
        //MenuItem mymenuItem = new MenueItem(bool isExe, string optionTitle);
        // members : List menue, execute() : 1. create new menue
        // 2. run function.

        private List<Interfaces.MenuMember> m_MenueList;
        private string m_UserMsg = "Please Chosse one of the following options or Exit (pick a number)";
        private string m_MenueTitle;

        public MainMenu(string i_menueTitle)
        {
            m_MenueList = new List<Interfaces.MenuMember>();
            m_MenueTitle = i_menueTitle;
        }

        public MainMenu(string i_menueTitle, List<Interfaces.MenuMember> i_menueMembers)
        {
            m_MenueList = i_menueMembers;
            m_MenueTitle = i_menueTitle;
        }


        public void addItemToMenu(Interfaces.MenuMember i_menuItemToAdd)
        {
            m_MenueList.Add(i_menuItemToAdd);
        }

        public void showMenu(Interfaces.IMenu i_menu)
        {
            int index = 1;
            Console.WriteLine(m_UserMsg);

            foreach (Interfaces.MenuMember item in m_MenueList)
            {
                Console.WriteLine(index + ". " + m_MenueTitle);
                index++;

            }

            Console.WriteLine("0. Exit");
            Console.WriteLine("Please choose your option :\t");
        }

        public int readInputFromUser()
        {
            bool inputIsLegit = true;
            int returnValue = -1;

            while (inputIsLegit)
            {
                int input = Console.Read();
                inputIsLegit = checkInputFromUser(input) > -1;

                if (inputIsLegit)
                {
                    returnValue = input;
                    inputIsLegit = false;
                }
            }

            return returnValue;
        }

        // return -1 if input isn't a digit.
        private int checkInputFromUser(int input)
        {
            int returnValue = -1 ;
            char c = (char)input;

            if (Char.IsDigit(c))
            {
                returnValue = c - '0';
            }
            return returnValue;
        }

        public void runCommand(Interfaces.MenuMember i_member)
        {
            //check if the member is type menu or menuItem
            if (i_member is Interfaces.IMenu)
            {
                showMenu(i_member);
            } 
            throw new NotImplementedException();
        }

        public string getTitle()
        {
            return m_MenueTitle;
        }

        public void quit()
        {
            throw new NotImplementedException();
        }
    }
}
