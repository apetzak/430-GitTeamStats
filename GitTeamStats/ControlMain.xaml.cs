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
using Microsoft.WindowsAPICodePack.Dialogs;
using GitTeamStats.Models;
using System.Data;

namespace GitTeamStats
{
    /// <summary>
    /// Interaction logic for ControlMain.xaml
    /// </summary>
    public partial class ControlMain : UserControl
    {
        private bool viewProfileWasClicked = false;

        public ControlMain()
        {
            InitializeComponent();
            Utils.SetTitle(RepoController.instance.folder);
            PopulateDataGrid();
        }

        private void PopulateDataGrid()
        {
            DataTable table = new DataTable();

            foreach (DataGridColumn c in dataGrid.Columns)
            {
                table.Columns.Add(c.Header.ToString());
            }

            foreach (Contributor c in RepoController.instance.contributors)
            {
                DataRow r = table.NewRow();
                r.ItemArray = new string[] {
                    "View Profile",
                    c.name,
                    c.email,
                    c.commits.Count.ToString(),
                    c.GetPercentOfCommits(dateTo.SelectedDate, dateFrom.SelectedDate),
                    c.GetLineAdditions(dateTo.SelectedDate, dateFrom.SelectedDate),
                    c.GetLineDeletions(dateTo.SelectedDate, dateFrom.SelectedDate),
                    c.GetNumberOfFilesEdited(dateTo.SelectedDate, dateFrom.SelectedDate)
                };
                table.Rows.Add(r);
            }
            dataGrid.ItemsSource = table.DefaultView;
        }

        private List<string> GetFileExtensionsInRepo()
        {
            var list = new List<String>();



            return list;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ControlLaunch();
        }

        private void BtnGraph_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ControlGraph();
        }

        private void BtnCompare_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ControlCompare();
        }

        private void Date_CalendarClosed(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            e.Cancel = true;
        }

        private void DataGridCell_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            viewProfileWasClicked = (sender as DataGridCell).Column.Header.ToString() == "View Profile";
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (viewProfileWasClicked)
            {
                string email = (dataGrid.SelectedValue as DataRowView).Row.ItemArray[2].ToString();
                Contributor c = RepoController.instance.contributors.Where(v => v.email == email).ToList().First();
                this.Content = new ControlProfile(c);
            }
        }
    }
}
