using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        public string m_menuName;
        bool m_backFlag;
        int m_pointerToNestedLevel;

        List<string> m_savedTitles;
        List<MenuItem> m_subCategories;
        List<List<MenuItem>> m_historyTracker;



        public MainMenu(List<MenuItem> i_subCategories)
        {
            m_menuName = "Main Menu";
            m_subCategories = i_subCategories;
            m_historyTracker = new List<List<MenuItem>>();
            m_savedTitles = new List<string>();
            m_backFlag = false;
            m_pointerToNestedLevel = 1;
        }

        private List<MenuItem> goUpInMenu()
        {
            List<MenuItem> upperLevel = null;
            int amount = m_historyTracker.Count;
            if (!(amount == 0))
            {
                upperLevel = m_historyTracker[m_savedTitles.Count - 1];
                m_historyTracker.RemoveAt(m_savedTitles.Count - 1);
                m_savedTitles.RemoveAt(m_savedTitles.Count - 1);
            }
            updateFlag(upperLevel);

            return upperLevel;
        }

        public void Show()
        {
            MenuItem currentChoice;
            int userChoice = -1;
            List<MenuItem> pointerToCurrentMenu = m_subCategories;


            while (!m_backFlag)
            {
                Console.Clear();
                userChoice = printMenuItems(pointerToCurrentMenu);//mapping input to int of as a chioce

                if (userChoice != 0)
                {
                    int indexInList = userChoice - 1;
                    currentChoice = pointerToCurrentMenu[indexInList];

                    if (currentChoice.m_menuItems == null)
                    {
                        currentChoice.Execute();
                    }

                    else
                    {
                        if (currentChoice.m_menuItems.Count != 0)
                        {
                            m_menuName = pointerToCurrentMenu[indexInList].m_title;
                            pointerToCurrentMenu = updateLists(pointerToCurrentMenu, currentChoice, indexInList);
                            m_pointerToNestedLevel++;
                        }
                    }

                }
                else
                {
                    pointerToCurrentMenu = goUpInMenu();
                    m_pointerToNestedLevel--;
                }
            }


        }


        private List<MenuItem> updateLists(List<MenuItem> i_menuItem, MenuItem i_updateChoice, int index)
        {
            m_historyTracker.Add(i_menuItem);
            m_savedTitles.Add(i_menuItem[index].m_title);
            return i_updateChoice.m_menuItems;
        }


        private int printMenuItems(List<MenuItem> i_itemsToPrint)
        {
            string sessionHeader = getCurrentPathString();
            string endSession = "0) " + (m_backFlag ? "Back." : "Exit.");
            string optionsString = generateOptionsString(i_itemsToPrint);

            optionsString += endSession;//no line sperator needed here

            Console.WriteLine(sessionHeader);
            Console.WriteLine(optionsString);

            return getInput(i_itemsToPrint.Count);

        }


        private string generateOptionsString(List<MenuItem> i_items)
        {
            string optionsString = "";
            int index = 1;

            foreach (MenuItem item in i_items)
            {
                optionsString += index + ") " + item.m_title + ".\n";
                index++;
            }

            return optionsString;
        }



        private string getCurrentPathString()
        {
            string path = "";
            for (int i = 0; i < m_historyTracker.Count; i++)
            {
                path += m_savedTitles[i] + "→";
            }
            return path;
        }

        private int getInput(int i_amountOfOptions)
        {

            string header = "Please enter your choice : ",
                errorString = "Seems like your choice isn't valid please try again :";

            Console.WriteLine(header);

            int choice = Convert.ToInt32(Console.ReadLine());
            while (verifyInput(choice, i_amountOfOptions) == -1)
            {
                Console.WriteLine(errorString);
                choice = Convert.ToInt32(Console.ReadLine());
            }
            return choice;

        }

        private int verifyInput(int i_choice, int i_capacity)
        {
            //converting char to int
            int value = -1;
            if (i_choice > -1 && i_choice <= i_capacity)
            {
                value = i_choice;
            }
            return value;

        }




        private void updateFlag(List<MenuItem> i_upperLevel)
        {
            if (i_upperLevel == null)
            {
                m_backFlag = true;
            }
            else
            {
                m_backFlag = false;
            }
        }
    }
}
