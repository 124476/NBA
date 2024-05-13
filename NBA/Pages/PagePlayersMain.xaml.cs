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
        int currentPage;
        int pageCount;
        int showCount = 10;


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
            var seasons = App.DB.Season.ToList();
            seasons.Add(new Season() { Name = "All" });
            ComboSeasons.ItemsSource = seasons;

            var teams = App.DB.Team.ToList();
            teams.Insert(0, new Team() { TeamName = "All" });
            ComboTeams.ItemsSource = teams;

            AllDown.Content = "<<";
            Down.Content = "<";
            Up.Content = ">";
            AllUp.Content = ">>";
            currentPage = 1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach(var item in StackButtons.Children)
            {
                (item as Button).Background = Brushes.Blue;
            }
            (sender as Button).Background = Brushes.Gray;
            allText = (sender as Button).Content.ToString();

            currentPage = 1;
            Refresh();
        }

        private void PoiskText_TextChanged(object sender, TextChangedEventArgs e)
        {
            currentPage = 1;
            Refresh();
        }

        private void ComboTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentPage = 1;
            Refresh();
        }

        private void ComboSeasons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentPage = 1;
            App.season = (ComboSeasons.SelectedItem as Season);
            if ((ComboSeasons.SelectedItem as Season).Name == "All")
                App.season = null;
            Refresh();
        }

        private void Refresh()
        {
            var players = App.DB.PlayerInTeam.ToList();
            var selectedTeam = (ComboTeams.SelectedItem as Team);
            var selectedSeasson = (ComboSeasons.SelectedItem as Season);

            if (ComboTeams.SelectedIndex != -1 && selectedTeam.TeamName != "All")
                players = players.Where(p => p.TeamId == selectedTeam.TeamId).ToList();

            if (allText != "All")
                players = players.Where(x => x.Player.Name.StartsWith(allText)).ToList();

            if (ComboSeasons.SelectedIndex != -1 && selectedSeasson.Name != "All")
                players = players.Where(x => x.SeasonId == selectedSeasson.SeasonId).ToList();

            players = players.Where(x => x.Player.Name.ToLower().Contains(PoiskText.Text.ToLower())).ToList();
            
            var tableData = players.Select(x => x.Player).ToList().Distinct().ToList();
            
            var totalPlayers = tableData.Count;

            pageCount = tableData.Count / showCount;

            if (totalPlayers % showCount != 0)
                pageCount++;

            tableData = tableData.Skip((currentPage - 1) * showCount).Take(showCount).ToList();

            DataPlayers.ItemsSource = tableData;

            AllPage.Text = pageCount.ToString();
            OnePage.Text = currentPage.ToString();
            TextAll.Text = $" Total {totalPlayers} recoreds, {tableData.Count} records in one page";
        }

        private void AllDown_Click(object sender, RoutedEventArgs e)
        {
            currentPage = 1;
            Refresh();
        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
            }
            Refresh();
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            if (currentPage < pageCount)
            {
                currentPage++;
            }
            Refresh();
        }

        private void AllUp_Click(object sender, RoutedEventArgs e)
        {
            currentPage = pageCount;
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
