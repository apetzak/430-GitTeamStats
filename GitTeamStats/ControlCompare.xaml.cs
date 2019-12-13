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
using LibGit2Sharp;

namespace GitTeamStats
{
    /// <summary>
    /// Interaction logic for ControlCompare.xaml
    /// </summary>
    public partial class ControlCompare : UserControl
    {
        public ControlCompare()
        {
            InitializeComponent();
            Utils.SetTitle(RepoController.instance.folder + " - Compare");
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ControlMain();
        }

        private void Date_CalendarClosed(object sender, RoutedEventArgs e)
        {

        }
    }
}
