using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MenuMember : IExecutableItem
    {
        //define members
        string m_Title;
        protected List<MenuMember> m_MenuMembersList;
        private IExecutableItem m_ExecutableItem;

        //given a menue title and a function to execute
        public MenuMember(string i_menueTitle, IExecutableItem i_MethodToExecute)
        {
            m_Title = i_menueTitle;
            m_ExecutableItem = i_MethodToExecute;
        }

        //given a list with menu members and a title menue
        public MenuMember(List<MenuMember> i_MenuList, string i_menueTitle)
        {
            m_MenuMembersList = i_MenuList;
            m_Title = i_menueTitle;
        }

        public void runCommand()
        {
            m_ExecutableItem.runCommand();
        }


        public List<MenuMember> getMenueMembers
        {
            get
            {
                return m_MenuMembersList;
            }
        }

        public string getTitle
        {
            get
            {
                return m_Title;
            }
        }

        public bool isExecutable
        {
            get
            {
                return m_ExecutableItem != null;
            }
        }
    }
}
