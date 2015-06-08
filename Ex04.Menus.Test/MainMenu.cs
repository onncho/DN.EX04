using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    public class MainMenu
    {
        private readonly List<Interfaces.MenuMember> m_MenueList;
        private string m_UserMsg = "Please Chosse one of the following options or Exit (pick a number)";

        private string m_MenueTitle;


        public MainMenu(string i_menueTitle, List<Interfaces.MenuMember> i_menueMembers)
        {
            m_MenueList = i_menueMembers;
            m_MenueTitle = i_menueTitle;
        }

        //check and delete
        public MainMenu(List<Interfaces.MenuMember> i_menueMembers)
        {
            m_MenueList = i_menueMembers;
        }


        public void addItemToMenu(Interfaces.MenuMember i_menuItemToAdd)
        {
            m_MenueList.Add(i_menuItemToAdd);
        }

        public void show()
        {
            showMenu(m_MenueList);
        }


        public void showMenu(List<Interfaces.MenuMember> i_MenueMembers)
        {
            bool quit = false;

            while (!quit)
            {
                Console.Clear();

                int index = 1;
                Console.WriteLine(m_UserMsg);

                foreach (Interfaces.MenuMember item in i_MenueMembers)
                {
                    Console.WriteLine(index + ". " + item.getTitle);
                    index++;

                }

                Console.WriteLine("0. Exit");
                Console.WriteLine("Please choose your option :");
                quit = userActionFlow(m_MenueList, readInputFromUser());
            }
            
        }

        private bool userActionFlow(List<Interfaces.MenuMember> i_MenueList, int i_userAction)
        {
            bool quit = false;

            if (i_userAction == 0)
            {
                quit = true;
            }
            else if (!(i_MenueList[i_userAction - 1].isExecutable))
            {
                showMenu(i_MenueList[i_userAction - 1].getMenueMembers);
            }
            else
            {
                i_MenueList[i_userAction - 1].runCommand();
            }

            return quit;
        }

        public int readInputFromUser()
        {
            bool inputIsLegit = true;
            int returnValue = -1;

            while (inputIsLegit)
            {
                //int input = Console.Read();
                int input = Convert.ToInt32(Console.ReadLine());
                //int checkInput = checkInputFromUser(input);
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
            int returnValue = -1 ;
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
