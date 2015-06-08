using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    class DelegateMenuTest
    {
        DelegateTestDateAndTime m_categoryOne = new DelegateTestDateAndTime();
        DelegateTestInfoVersion m_categoryTwo = new DelegateTestInfoVersion();
        
        private Dictionary<string, List<Ex04.Menus.Delegates.MenuItem>> m_delegates = new Dictionary<string, List<Ex04.Menus.Delegates.MenuItem>>()
        {
            {"TimeAndDate", new List<Ex04.Menus.Delegates.MenuItem>() },
            {"InfoAndVersion", new List<Ex04.Menus.Delegates.MenuItem>() },
            {"MainMenu", new List<Ex04.Menus.Delegates.MenuItem>() }
        };

        private void initComponents()
        {
            string firstCategoryFirstTitle = "Show Time";
            string firstCategorySecondTitle = "Show Date";
            string secondCategoryFirstTitle = "Show Version";
            string secondCategorySecondTitle = "Count Words";

            Ex04.Menus.Delegates.DelegateExecuteItem delegateOfTime = new Ex04.Menus.Delegates.DelegateExecuteItem(m_categoryOne.printTimeFromString);
            Ex04.Menus.Delegates.DelegateExecuteItem delegateOfDate = new Ex04.Menus.Delegates.DelegateExecuteItem(m_categoryOne.printDateFromString);


            Ex04.Menus.Delegates.DelegateExecuteItem delegateOfVersion = new Ex04.Menus.Delegates.DelegateExecuteItem(m_categoryTwo.printVersionFromString);
            Ex04.Menus.Delegates.DelegateExecuteItem delegateOfCountWords = new Ex04.Menus.Delegates.DelegateExecuteItem(m_categoryTwo.printCountWordsFromString);

            Ex04.Menus.Delegates.MenuItem menuItemForTime = new Ex04.Menus.Delegates.MenuItem(delegateOfTime, firstCategoryFirstTitle);
            Ex04.Menus.Delegates.MenuItem menuItemForDate = new Ex04.Menus.Delegates.MenuItem(delegateOfDate, firstCategorySecondTitle);

            Ex04.Menus.Delegates.MenuItem menuItemForVersion = new Ex04.Menus.Delegates.MenuItem(delegateOfVersion, secondCategoryFirstTitle);
            Ex04.Menus.Delegates.MenuItem menuItemForCountWords = new Ex04.Menus.Delegates.MenuItem(delegateOfCountWords, secondCategorySecondTitle);

            m_delegates["TimeAndDate"].Add(menuItemForTime);
            m_delegates["TimeAndDate"].Add(menuItemForDate);
            m_delegates["InfoAndVersion"].Add(menuItemForVersion);
            m_delegates["InfoAndVersion"].Add(menuItemForCountWords);
        }




        public void ShowMenu()
        {
            initComponents();

            string dateTimeStringForMainMenu = "Show Date / Time";
            string infoStringForMainMenu = "Info";

            Ex04.Menus.Delegates.MenuItem menuItemTimeAndDateMainMenu = new Ex04.Menus.Delegates.MenuItem(m_delegates["TimeAndDate"], dateTimeStringForMainMenu);
            Ex04.Menus.Delegates.MenuItem menuItemInfoAndVersionMainMenu = new Ex04.Menus.Delegates.MenuItem(m_delegates["InfoAndVersion"], infoStringForMainMenu);

            m_delegates["MainMenu"].Add(menuItemTimeAndDateMainMenu);
            m_delegates["MainMenu"].Add(menuItemInfoAndVersionMainMenu);

            Ex04.Menus.Delegates.MainMenu delegateMainMenu = new Ex04.Menus.Delegates.MainMenu(m_delegates["MainMenu"]);
            delegateMainMenu.Show();
        }

    }
}
