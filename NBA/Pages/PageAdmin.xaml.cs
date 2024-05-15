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
    /// Логика взаимодействия для PageAdmin.xaml
    /// </summary>
    public partial class PageAdmin : Page
    {
        public PageAdmin()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.IsLog = 1;
            App.mainText = "Event Administrator Menu";
        }

        private void ManageSeasons_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageManageSeasons());
        }

        private void Matchups_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageManageMatchups());
        }

        private void ManagePlayers_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageManagePlayers());
        }

        private void ManageTeams_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageManageTeam());
        }
    }
}
