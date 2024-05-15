using NBA.Models;
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

namespace NBA.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageTeamReport.xaml
    /// </summary>
    public partial class PageTeamReport : Page
    {
        public PageTeamReport()
        {
            InitializeComponent();

            var types = App.DB.MatchupType.Where(x => x.MatchupTypeId <= 1).ToList();
            ComboTypes.ItemsSource = types;
            ComboTypes.SelectedIndex = 0;

            ComboRanks.ItemsSource = new string[]
            {
                "Points",
                "Rebounds",
                "Assists",
                "Steals",
                "Blocks"
            };
            ComboRanks.SelectedIndex = 0;

            ComboView.ItemsSource = new string[]
            {
                "Average",
                "Total"
            };
            ComboView.SelectedIndex = 0;
            App.IsRange = true;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.mainText = "Team Report";
            App.IsLog = 2;
            Refresh();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            var teams = App.DB.Matchup.ToList();
            var seasson = App.DB.Season.ToList().Last();
            var type = ComboTypes.SelectedItem as MatchupType;

            teams = teams.Where(x => x.SeasonId == seasson.SeasonId).ToList();
            teams = teams.Where(x => x.MatchupTypeId == type.MatchupTypeId).ToList();

            var reports = teams.Select(x => x.Team).ToList();
            reports = reports.Distinct().ToList();
            
            if (ComboView.SelectedIndex == 0)
                App.IsRange = true;
            else
                App.IsRange = false;

            if (ComboRanks.SelectedIndex == 0)
                reports = reports.OrderBy(x => x.Points).ToList();
            if (ComboRanks.SelectedIndex == 1)
                reports = reports.OrderBy(x => x.Rebounds).ToList();
            if (ComboRanks.SelectedIndex == 2)
                reports = reports.OrderBy(x => x.Assists).ToList();
            if (ComboRanks.SelectedIndex == 3)
                reports = reports.OrderBy(x => x.Steals).ToList();
            if (ComboRanks.SelectedIndex == 4)
                reports = reports.OrderBy(x => x.Blocks).ToList();

            DataReports.ItemsSource = reports;
            App.teams = reports;
        }
    }
}
