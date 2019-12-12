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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            BaseWindow.OpenWindow(typeof(LoginWindow), this);
        }

        private void BtnGraph_Click(object sender, RoutedEventArgs e)
        {
            BaseWindow.OpenWindow(typeof(GraphWindow), this);
        }

        private void BtnCompare_Click(object sender, RoutedEventArgs e)
        {
            BaseWindow.OpenWindow(typeof(ComparisonWindow), this);
        }

        private void BtnProfile_Click(object sender, RoutedEventArgs e)
        {
            BaseWindow.OpenWindow(typeof(ProfileWindow), this);
        }

        private void Date_CalendarClosed(object sender, RoutedEventArgs e)
        {

        }
    }
}
