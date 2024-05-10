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
            Up.Content = ">";
            Down.Content = "<";
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
            DataTeams.ItemsSource = App.DB.Matchup.ToList();
        }

        private void View_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
