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
    /// Логика взаимодействия для PageMatchups.xaml
    /// </summary>
    public partial class PageMatchups : Page
    {
        public PageMatchups()
        {
            InitializeComponent();
            PoiskDate.SelectedDate = DateTime.Now;
            Down.Content = ">";
            Up.Content = "<";
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            if (PoiskDate.SelectedDate != null)
            {
                PoiskDate.SelectedDate -= TimeSpan.FromDays(1);
            }
            Refresh();
        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            if (PoiskDate.SelectedDate != null)
            {
                PoiskDate.SelectedDate += TimeSpan.FromDays(1);
            }
            Refresh();
        }

        private void PoiskDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            App.dateNow = PoiskDate.SelectedDate.Value + TimeSpan.FromHours(DateTime.Now.Hour) + TimeSpan.FromMinutes(DateTime.Now.Minute);

            var maths = App.DB.Matchup.Where(x => x.Starttime.Year == PoiskDate.SelectedDate.Value.Year &&
            x.Starttime.Month == PoiskDate.SelectedDate.Value.Month && x.Starttime.Day == PoiskDate.SelectedDate.Value.Day).OrderBy(x => x.Starttime).ToList();
            DataTeams.ItemsSource = maths;
            bool IsCan = true;
            foreach (var item in maths)
            {
                if (item.StatusName == "Not Start")
                {
                    DataContext = item;
                    IsCan = false;
                    break;
                }
            }
            if (IsCan)
                DataContext = null;
        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
            Matchup matchup = (sender as Button).DataContext as Matchup;
            if (matchup != null)
            {
                NavigationService.Navigate(new PageMathup(matchup));
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.mainText = "Matchup List";
        }
    }
}
