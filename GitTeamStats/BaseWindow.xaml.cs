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
using System.Windows.Shapes;

namespace GitTeamStats
{
    /// <summary>
    /// Interaction logic for BaseWindow.xaml
    /// </summary>
    public partial class BaseWindow : Window
    {
        public BaseWindow()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(typeof(MainWindow), this);
        }

        public static void OpenWindow(Type t, Window self)
        {
            Window window = Activator.CreateInstance(t) as Window;
            window.Left = self.Left;
            window.Top = self.Top;
            window.Show();
            self.Close();
        }
    }
}
