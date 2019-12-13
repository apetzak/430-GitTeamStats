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
using GitTeamStats.Models;
using LibGit2Sharp;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace GitTeamStats
{
    /// <summary>
    /// Interaction logic for ControlLogin.xaml
    /// </summary>
    public partial class ControlLaunch : UserControl
    {
        public ControlLaunch()
        {
            InitializeComponent();
            Utils.SetTitle("Select Repo");
            //txtFilePath.Text = "D:\\Projects\\Github Repos\\255-Outbreak"; < for testing
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ControlMain();
        }

        private void BtnSelect_Click(object sender, RoutedEventArgs e)
        {
            RepoController.instance.repo = RepoLoader.ShowDialog();
            txtFilePath.Text = RepoController.instance.filePath;
        }

        private void TxtFilePath_TextChanged(object sender, TextChangedEventArgs e)
        {
            RepoController.instance.repo = RepoLoader.OpenFromPath(txtFilePath.Text);
            OpenRepo();
        }

        private void OpenRepo()
        {
            if (RepoController.instance.repo != null)
            {
                lblSelectedRepo.Content = RepoController.instance.folder;
                btnOk.IsEnabled = true;
                btnSelect.Content = "Change Repo";
            }
            else
            {
                lblSelectedRepo.Content = "No Repo Selected";
                btnOk.IsEnabled = false;
                btnSelect.Content = "Select Repo";
            }

            RepoController.instance.GetContributors();
        }
    }
}
