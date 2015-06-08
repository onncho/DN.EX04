using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void DelegateExecuteItem();

    public class MenuItem
    {
        public DelegateExecuteItem m_executable;
        public string m_title;
        public List<MenuItem> m_menuItems;


        public MenuItem(List<MenuItem> i_menuItems, string i_title)
        {
            m_title = i_title;
            m_menuItems = i_menuItems;
        }

        public MenuItem(DelegateExecuteItem i_executable, string i_title)
        {
            m_title = i_title;
            m_executable = i_executable;

        }

        public void Execute()
        {
            m_executable.Invoke();
        }


    }
}
