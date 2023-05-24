using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace API_NotizApp_WPF
{
    public static class Switcher
    {
        public static MainWindow pageSwitcher;
        public static Menu menuSwitcher;
        public static Notiz notizSwitcher;

        public static void Switch(UserControl newPage)
        {
            pageSwitcher.Navigate(newPage);
        }
        
    }
}
