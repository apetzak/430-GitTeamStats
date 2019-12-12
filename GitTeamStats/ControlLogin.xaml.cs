﻿using System;
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
    /// Interaction logic for ControlLogin.xaml
    /// </summary>
    public partial class ControlLogin : UserControl
    {
        public ControlLogin()
        {
            InitializeComponent();
            MainWindow window = (MainWindow)App.Current.MainWindow;
            window.Title = "Git Team Stats - Login";
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ControlMain();
        }
    }
}
