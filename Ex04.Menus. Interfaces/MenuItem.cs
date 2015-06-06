using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    interface MenuItem
    {
        void run();
        void show();
        void getTitle();
        bool isExecutle();
        void quit();
    }
}
