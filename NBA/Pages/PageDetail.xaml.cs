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
    /// Логика взаимодействия для PageDetail.xaml
    /// </summary>
    public partial class PageDetail : Page
    {
        Team contextTeam;
        public PageDetail(Team team, int stage)
        {
            InitializeComponent();
            var seasons = App.DB.Season.ToList();
            seasons.Add(new Season() { Name = "All" });
            PoiskCombo.ItemsSource = seasons;
            contextTeam = team;
            var players = App.DB.PlayerInTeam.Where(x => x.TeamId == team.TeamId).Select(x => x.Player).ToList();
            var playerss = new List<Player>();
            foreach (var item in players)
            {
                if (playerss.Contains(item))
                    continue;
                playerss.Add(item);
            }
            DataPlayers.ItemsSource = playerss;
            DataMathups.ItemsSource = App.DB.Matchup.Where(x => x.Team.TeamId == team.TeamId).ToList();
            SG.ItemsSource = playerss.Where(x => x.PositionId == 4).ToList();
            PF.ItemsSource = playerss.Where(x => x.PositionId == 2).ToList();
            C.ItemsSource = playerss.Where(x => x.PositionId == 3).ToList();
            SF.ItemsSource = playerss.Where(x => x.PositionId == 1).ToList();
            PG.ItemsSource = playerss.Where(x => x.PositionId == 5).ToList();

            if (stage == 1)
            {
                DataPlayers.Visibility = Visibility.Visible;
                DataMathups.Visibility = Visibility.Collapsed;
                LineupGrid.Visibility = Visibility.Collapsed;
            }
            if (stage == 2)
            {
                DataPlayers.Visibility = Visibility.Collapsed;
                DataMathups.Visibility = Visibility.Visible;
                LineupGrid.Visibility = Visibility.Collapsed;
            }
            if (stage == 3)
            {
                DataPlayers.Visibility = Visibility.Collapsed;
                DataMathups.Visibility = Visibility.Collapsed;
                LineupGrid.Visibility = Visibility.Visible;
            }
            DataContext = contextTeam;
        }

        private void Roster_Click(object sender, RoutedEventArgs e)
        {
            DataPlayers.Visibility = Visibility.Visible;
            DataMathups.Visibility = Visibility.Collapsed;
            LineupGrid.Visibility = Visibility.Collapsed;
        }

        private void Mathup_Click(object sender, RoutedEventArgs e)
        {
            DataPlayers.Visibility = Visibility.Collapsed;
            DataMathups.Visibility = Visibility.Visible;
            LineupGrid.Visibility = Visibility.Collapsed;
        }

        private void Lineup_Click(object sender, RoutedEventArgs e)
        {
            DataPlayers.Visibility = Visibility.Collapsed;
            DataMathups.Visibility = Visibility.Collapsed;
            LineupGrid.Visibility = Visibility.Visible;
        }

        private void SearhBtn_Click(object sender, RoutedEventArgs e)
        {
            if (PoiskCombo.SelectedIndex == -1 || PoiskCombo.Text != "All")
            {
                var seassonId = (PoiskCombo.SelectedItem as Season).SeasonId;
                DataMathups.ItemsSource = App.DB.Matchup.Where(x => x.Team.TeamId == contextTeam.TeamId && x.SeasonId == seassonId).ToList();
                return;
            }

            DataMathups.ItemsSource = App.DB.Matchup.Where(x => x.Team.TeamId == contextTeam.TeamId).ToList();
        }
    }
}
