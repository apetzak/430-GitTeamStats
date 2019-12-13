using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTeamStats
{
    class Utils
    {
        public static void SetTitle(string title)
        {
            MainWindow window = (MainWindow)App.Current.MainWindow;
            window.Title = "Git Team Stats - " + title;
        }
    }
}
