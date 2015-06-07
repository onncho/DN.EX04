using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public interface IMenuItem
    {
        void runCommand();
        //void show();
        string getTitle();
        //bool isExecutle();
        void quit();
    }
}
