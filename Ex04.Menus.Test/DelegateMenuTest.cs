using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    class DelegateMenuTest
    {
        DelegateTestDateAndTime m_categoryOne = new DelegateTestDateAndTime();
        DelegateTestInfoVersion m_categoryTwo = new DelegateTestInfoVersion();

        private Dictionary<string, List<Ex04_GalRettig.MenuItem>> m_delegates = new Dictionary<string, List<Ex04_GalRettig.MenuItem>>()
        {
            {"TimeAndDate", new List<Ex04_GalRettig.MenuItem>() },
            {"InfoAndVersion", new List<Ex04_GalRettig.MenuItem>() },
            {"MainMenu", new List<Ex04_GalRettig.MenuItem>() }
        };

        private void initComponents()
        {
            string firstCategoryFirstTitle = "Show Time";
            string firstCategorySecondTitle = "Show Date";
            string secondCategoryFirstTitle = "Show Version";
            string secondCategorySecondTitle = "Count Words";

            Ex04_GalRettig.DelegateExecuteItem delegateOfTime = new Ex04_GalRettig.DelegateExecuteItem(m_categoryOne.printTimeFromString);
            Ex04_GalRettig.DelegateExecuteItem delegateOfDate = new Ex04_GalRettig.DelegateExecuteItem(m_categoryOne.printDateFromString);


            Ex04_GalRettig.DelegateExecuteItem delegateOfVersion = new Ex04_GalRettig.DelegateExecuteItem(m_categoryTwo.printVersionFromString);
            Ex04_GalRettig.DelegateExecuteItem delegateOfCountWords = new Ex04_GalRettig.DelegateExecuteItem(m_categoryTwo.printCountWordsFromString);

            Ex04_GalRettig.MenuItem menuItemForTime = new Ex04_GalRettig.MenuItem(delegateOfTime, firstCategoryFirstTitle);
            Ex04_GalRettig.MenuItem menuItemForDate = new Ex04_GalRettig.MenuItem(delegateOfDate, firstCategorySecondTitle);

            Ex04_GalRettig.MenuItem menuItemForVersion = new Ex04_GalRettig.MenuItem(delegateOfVersion, secondCategoryFirstTitle);
            Ex04_GalRettig.MenuItem menuItemForCountWords = new Ex04_GalRettig.MenuItem(delegateOfCountWords, secondCategorySecondTitle);

            m_delegates["TimeAndDate"].Add(menuItemForTime);
            m_delegates["TimeAndDate"].Add(menuItemForDate);
            m_delegates["InfoAndVersion"].Add(menuItemForVersion);
            m_delegates["InfoAndVersion"].Add(menuItemForCountWords);
        }




        public void initMenu()
        {
            initComponents();

            string dateTimeStringForMainMenu = "Show Date / Time";
            string infoStringForMainMenu = "Info";

            Ex04_GalRettig.MenuItem menuItemTimeAndDateMainMenu = new Ex04_GalRettig.MenuItem(m_delegates["TimeAndDate"], dateTimeStringForMainMenu);
            Ex04_GalRettig.MenuItem menuItemInfoAndVersionMainMenu = new Ex04_GalRettig.MenuItem(m_delegates["InfoAndVersion"], infoStringForMainMenu);

            m_delegates["MainMenu"].Add(menuItemTimeAndDateMainMenu);
            m_delegates["MainMenu"].Add(menuItemInfoAndVersionMainMenu);

            Ex04_GalRettig.MainMenu delegateMainMenu = new Ex04_GalRettig.MainMenu(m_delegates["MainMenu"]);
            delegateMainMenu.Show();
        }

    }
}
