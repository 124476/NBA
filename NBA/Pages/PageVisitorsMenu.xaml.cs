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
    /// Логика взаимодействия для PageVisitorsMenu.xaml
    /// </summary>
    public partial class PageVisitorsMenu : Page
    {
        public PageVisitorsMenu()
        {
            App.mainText = "Visitor Menu";
            InitializeComponent();
        }

        private void Team_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageTeam());
        }

        private void Photos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Mathups_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Players_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
