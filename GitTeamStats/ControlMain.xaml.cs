using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GitTeamStats
{
    /// <summary>
    /// Interaction logic for ControlMain.xaml
    /// </summary>
    public partial class ControlMain : UserControl
    {
        public ControlMain()
        {
            InitializeComponent();
            MainWindow window = (MainWindow)App.Current.MainWindow;
            window.Title = "Git Team Stats - Main";
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ControlLogin();
        }

        private void BtnGraph_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ControlGraph();
        }

        private void BtnCompare_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ControlCompare();
        }

        private void BtnProfile_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ControlProfile();
        }

        private void Date_CalendarClosed(object sender, RoutedEventArgs e)
        {

        }
    }
}
