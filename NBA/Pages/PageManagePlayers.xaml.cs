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
    /// Логика взаимодействия для PageManagePlayers.xaml
    /// </summary>
    public partial class PageManagePlayers : Page
    {
        public PageManagePlayers()
        {
            InitializeComponent();

            var positions = App.DB.Position.ToList();
            positions.Insert(0, new Position()
            {
                Name = "All"
            });
            ComboPositions.ItemsSource = positions;

            var countryes = App.DB.Country.ToList();
            countryes.Insert(0, new Country()
            {
                CountryName = "All"
            });
            ComboCountryes.ItemsSource = countryes;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.mainText = "Manage Players";
            App.IsLog = 2;
            Refresh();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            var players = App.DB.Player.ToList();
            var position = (ComboPositions.SelectedItem as Position);
            var country = (ComboCountryes.SelectedItem as Country);


            if (ComboPositions.SelectedIndex != -1 && position.Name != "All")
                players = players.Where(x => x.PositionId == position.PositionId).ToList();

            if (ComboCountryes.SelectedIndex != -1 && country.CountryName != "All")
                players = players.Where(x => x.CountryCode == country.CountryCode).ToList();

            players = players.Where(x => x.Name.ToLower().Contains(TextName.Text.ToLower())).ToList();

            DataPlayers.ItemsSource = players;
            TotalText.Text = $"Total players: {players.Count()}";
        }
    }
}
