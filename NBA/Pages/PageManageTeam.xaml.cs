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
using System.Windows.Threading;

namespace NBA.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageManageTeam.xaml
    /// </summary>
    public partial class PageManageTeam : Page
    {
        DispatcherTimer dispatcherTimer;
        public PageManageTeam()
        {
            InitializeComponent();

            var confernce = App.DB.Conference.ToList();
            confernce.Add(new Conference() { Name = "All" });
            ComboConferences.ItemsSource = confernce;

            var divisions = App.DB.Division.ToList();
            divisions.Add(new Division() { Name = "All" });
            ComboDivisions.ItemsSource = divisions;

            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += RefreshTick;
            dispatcherTimer.Interval = TimeSpan.FromSeconds(2);
            dispatcherTimer.Start();
            Refresh();
        }

        private void RefreshTick(object sender, EventArgs e)
        {
            dispatcherTimer.Stop();
            MessageBox.Show("Add a new team – Future Add-on", "The  feature would be a future add-on to the current system.");
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.IsLog = 2;
            App.mainText = "Manage Team";
            Refresh();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            var teams = App.DB.Team.ToList();
            var conference = (ComboConferences.SelectedItem as Conference);
            var division = (ComboDivisions.SelectedItem as Division);

            if (ComboConferences.SelectedIndex != -1 && conference.Name != "All")
                teams = teams.Where(x => x.Division.Conference.ConferenceId == conference.ConferenceId).ToList();

            if (ComboDivisions.SelectedIndex != -1 && division.Name != "All")
                teams = teams.Where(x => x.Division.DivisionId == division.DivisionId).ToList();

            teams = teams.Where(x => x.TeamName.ToLower().Contains(PoiskText.Text.ToLower())).ToList();

            DataTeams.ItemsSource = teams;
            TotalText.Text = $"Total teams: {teams.Count}";
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageNewTeam());
        }
    }
}
