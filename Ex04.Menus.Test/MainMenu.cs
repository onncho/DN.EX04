using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    public class MainMenu
    {
        protected readonly List<Interfaces.MenuMember> r_MenueList;
        private const string k_UserMsg = "Please Chosse one of the following options (pick a number):\n";
        private const string k_ExitMenu = "0. Exit\n";
        private const string k_BackMenu = "0. Back\n";
        private const string k_ErrorMsg = "Seems that you enters illegal option number, please try again";
        private int m_menuLevel = 0;
        private string m_MenueTitle;
        private string m_innerMenuTitle;

        public MainMenu(string i_menueTitle, List<Interfaces.MenuMember> i_menueMembers)
        {
            r_MenueList = i_menueMembers;
            m_MenueTitle = i_menueTitle;
        }

        //check and delete
        public MainMenu(List<Interfaces.MenuMember> i_menueMembers)
        {
            r_MenueList = i_menueMembers;
        }

        //menu item to add can be menu or a command to execute
        public void addItemToMenu(Interfaces.MenuMember i_menuItemToAdd)
        {
            r_MenueList.Add(i_menuItemToAdd);
        }

        public void show()
        {
            showMenu(r_MenueList, null);
        }

        public void showMenu(List<Interfaces.MenuMember> i_MenueMembers, string i_menuTitle)
        {
            bool quit = false; 

            while (!quit)
            {
                Console.Clear();

                int index = 1;

                if (m_menuLevel == 0)
                {
                    Console.WriteLine("Welcome to the Main Menu");
                    Console.WriteLine("========================\n");
                }

                if (m_menuLevel > 0)
                {
                    Console.WriteLine(i_menuTitle + " Menu: \n");
                }
                Console.WriteLine(k_UserMsg);

                foreach (Interfaces.MenuMember item in i_MenueMembers)
                {
                    Console.WriteLine(index + ". " + item.getTitle + "\n");
                    index++;
                }

                if (m_menuLevel > 0)
                {
                    Console.WriteLine(k_BackMenu);
                }
                else
                {
                    Console.WriteLine(k_ExitMenu);
                }

                Console.WriteLine("Please choose your option :");
                quit = userActionFlow(i_MenueMembers, readInputFromUser());
            }

        }

        private bool userActionFlow(List<Interfaces.MenuMember> i_MenueList, int i_userAction)
        {
            bool quit = false;
            int numOfMenuItems = i_MenueList.Count;

            if (i_userAction == 0)
            {
                //decrease menu level only from the second menu, also to avoid execeptions
                if (m_menuLevel > 0)
                {
                    m_menuLevel--;
                }

                quit = true;
            }
            else if (i_userAction <= numOfMenuItems)
            {

                if (!(i_MenueList[i_userAction - 1].isExecutable))
                {
                    m_menuLevel++;
                    showMenu(i_MenueList[i_userAction - 1].getMenueMembers, i_MenueList[i_userAction - 1].getTitle);
                }
                else
                {
                    i_MenueList[i_userAction - 1].runCommand();
                }
            }
            else
            {
                Console.WriteLine(k_ErrorMsg);
                Console.WriteLine("Press Any Key To Choose Again..");
                Console.ReadLine();
            }

            return quit;
        }

        public int readInputFromUser()
        {
            bool inputIsLegit = true;
            int returnValue = -1;

            while (inputIsLegit)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                inputIsLegit = input > -1;

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
            int returnValue = -1;
            char c = (char)input;

            if (Char.IsDigit(c))
            {
                returnValue = c - '0';
            }

            return returnValue;
        }

        public string getTitle()
        {
            return m_MenueTitle;
        }
    }
}
