using NBA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
using System.Xml;

namespace NBA.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePlayersMain.xaml
    /// </summary>
    public partial class PagePlayersMain : Page
    {
        string allText;
        int dataId;
        List<Player> players;
        public PagePlayersMain()
        {
            InitializeComponent();
            App.mainText = "Players Main";

            allText = "All";
            Button button = new Button();
            button.Content = "All";
            button.Click += Button_Click;
            button.Background = Brushes.Blue;
            button.Width = 30;
            StackButtons.Children.Add(button);

            for (char i = 'A'; i <= 'Z'; i++)
            {
                button = new Button();
                button.Content = i.ToString();
                button.Click += Button_Click;
                button.Background = Brushes.Blue;
                button.Width = 27;
                StackButtons.Children.Add(button);
            }

            var dates = new List<string>() { "All" };
            DateTime dateStart = DateTime.Now.AddYears(-24);
            DateTime dateEnd = DateTime.Now;
            while (dateEnd > dateStart)
            {
                dates.Add(dateStart.Year.ToString() + " - " + dateStart.AddYears(1).Year.ToString());
                dateStart = dateStart.AddYears(1);
            }

            ComboSeasons.ItemsSource = dates;

            var teams = App.DB.Team.ToList();
            teams.Insert(0, new Team() { TeamName = "All" });
            ComboTeams.ItemsSource = teams;

            AllDown.Content = "<<";
            Down.Content = "<";
            Up.Content = ">";
            AllUp.Content = ">>";
            dataId = 1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach(var item in StackButtons.Children)
            {
                (item as Button).Background = Brushes.Blue;
            }
            (sender as Button).Background = Brushes.Gray;
            allText = (sender as Button).Content.ToString();

            dataId = 1;
            Refresh();
        }

        private void PoiskText_TextChanged(object sender, TextChangedEventArgs e)
        {
            dataId = 1;
            Refresh();
        }

        private void ComboTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dataId = 1;
            Refresh();
        }

        private void ComboSeasons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dataId = 1;
            Refresh();
        }

        private void Refresh()
        {
            players = new List<Player>();

            if (ComboTeams.SelectedIndex != -1 && (ComboTeams.SelectedItem as Team).TeamName != "All")
            {
                Team team = ComboTeams.SelectedItem as Team;
                var plays = App.DB.PlayerInTeam.Where(x => x.TeamId == team.TeamId).Select(x => x.Player).ToList();
                foreach(var player in plays)
                {
                    if (!players.Contains(player))
                    {
                        players.Add(player);
                    }
                }
            }
            else
            {
                players = App.DB.Player.ToList();
            }

            if (allText != "All")
                players = players.Where(x => x.Name.StartsWith(allText)).ToList();


            players = players.Where(x => x.Name.ToLower().Contains(PoiskText.Text.ToLower())).ToList();

            var play = players;
            for(int i = 1; i < dataId; i++)
            {
                play = play.Skip(10).ToList();
            }

            DataPlayers.ItemsSource = play.Take(10);
        }

        private void AllDown_Click(object sender, RoutedEventArgs e)
        {
            dataId = 1;
            Refresh();
        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            if (dataId > 1)
            {
                dataId--;
            }
            Refresh();
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            if (dataId < players.Count / 10)
            {
                dataId++;
            }
            Refresh();
        }

        private void AllUp_Click(object sender, RoutedEventArgs e)
        {
            dataId = players.Count / 10;
            Refresh();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.mainText = "Players Main";
            Refresh();
        }

        private void DataPlayers_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Player player = DataPlayers.SelectedItem as Player;
            if (player != null)
            {
                NavigationService.Navigate(new PagePlayer(player));
            }
        }
    }
}
