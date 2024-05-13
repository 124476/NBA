using NBA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для PageManageMatchups.xaml
    /// </summary>
    public partial class PageManageMatchups : Page
    {
        public PageManageMatchups()
        {
            InitializeComponent();
            ExportBtn.Visibility = Visibility.Hidden;
            NewBtn.Visibility = Visibility.Hidden;
            var seassions = App.DB.Season.ToList();
            seassions.Insert(0, new Season()
            {
                Name = "All"
            });
            PoiskCombo.ItemsSource = seassions;
            MessageBox.Show("Update Matchup – Future Add-on", "The  feature would be a future add-on to the current system.");
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.IsLog = 2;
            App.mainText = "Manage Matchups";
            Refresh();
        }

        private void RegularSeason_Click(object sender, RoutedEventArgs e)
        {
            ExportBtn.Visibility = Visibility.Visible;
            NewBtn.Visibility = Visibility.Visible;
        }

        private void Preseason_Click(object sender, RoutedEventArgs e)
        {
            ExportBtn.Visibility = Visibility.Hidden;
            NewBtn.Visibility = Visibility.Hidden;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            var matchups = App.DB.Matchup.ToList();
            var seasion = (PoiskCombo.SelectedItem as Season);
            var dateNow = PoiskDate.SelectedDate;

            if (PoiskCombo.SelectedIndex != -1 && seasion.Name != "All")
                matchups = matchups.Where(x => x.SeasonId == seasion.SeasonId).ToList();

            if (CheckDate.IsChecked == true && dateNow != null)
                matchups = matchups.Where(x => x.Starttime.Year == dateNow.Value.Year && x.Starttime.Month == dateNow.Value.Month && x.Starttime.Day == dateNow.Value.Day).ToList();

            DataMatchups.ItemsSource = matchups;
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            var matchup = (sender as Button).DataContext as Matchup;
            if (matchup != null)
            {
                NavigationService.Navigate(new PageNewMatchup(matchup));
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var matchup = (sender as Button).DataContext as Matchup;
            if (matchup != null)
            {
                App.DB.Matchup.Remove(matchup);
                App.DB.SaveChanges();
            }
        }

        private void NewBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageNewMatchup(new Matchup()));
        }

        private void ExportBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
