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
using LibGit2Sharp;
using GitTeamStats.Models;

namespace GitTeamStats
{
    /// <summary>
    /// Interaction logic for ControlProfile.xaml
    /// </summary>
    public partial class ControlProfile : UserControl
    {
        private Contributor contributor;

        public ControlProfile(Contributor c)
        {
            InitializeComponent();
            Utils.SetTitle(RepoController.instance.folder + " - Profile");
            contributor = c;
            SetLabelContent();
            SetListBoxContent();
        }

        private void SetLabelContent()
        {
            lblName.Content = contributor.name;
            lblEmail.Content = contributor.email;
            lblNumOfCommits.Content = contributor.commits.Count.ToString();
            lblPercentOfCommits.Content = contributor.GetPercentOfCommits(dateTo.SelectedDate, dateFrom.SelectedDate);
            lblLineAdditions.Content = contributor.GetLineAdditions(dateTo.SelectedDate, dateFrom.SelectedDate);
            lblLineDeletions.Content = contributor.GetLineDeletions(dateTo.SelectedDate, dateFrom.SelectedDate);
            lblNumOfFilesEdited.Content = contributor.GetNumberOfFilesEdited(dateTo.SelectedDate, dateFrom.SelectedDate);
        }

        private void SetListBoxContent()
        {

        }

        private void Date_CalendarClosed(object sender, RoutedEventArgs e)
        {
            SetLabelContent();
            SetListBoxContent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ControlMain();
        }
    }
}
