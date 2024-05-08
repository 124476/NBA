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
        Team contextText;
        public PageDetail(Team team)
        {
            InitializeComponent();
            var dates = new List<string>();
            DateTime dateStart = DateTime.Now.AddYears(-24);
            DateTime dateEnd = DateTime.Now;
            while (dateEnd > dateStart)
            {
                dates.Add(dateStart.Year.ToString() + " - " + dateStart.AddYears(1).Year.ToString());
                dateStart = dateStart.AddYears(1);
            }

            PoiskCombo.ItemsSource = dates;
            contextText = team;
            DataPlayers.ItemsSource = App.DB.PlayerInTeam.Where(x => x.TeamId == team.TeamId).Select(x => x.Player).ToList();
        }

        private void Roster_Click(object sender, RoutedEventArgs e)
        {
            DataPlayers.Visibility = Visibility.Visible;
        }

        private void Mathup_Click(object sender, RoutedEventArgs e)
        {
            DataPlayers.Visibility = Visibility.Hidden;
        }

        private void Lineup_Click(object sender, RoutedEventArgs e)
        {
            DataPlayers.Visibility = Visibility.Hidden;
        }

        private void SearhBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
