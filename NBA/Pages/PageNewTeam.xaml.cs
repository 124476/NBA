using Microsoft.Win32;
using NBA.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для PageNewTeam.xaml
    /// </summary>
    public partial class PageNewTeam : Page
    {
        Team contextTeam;
        public PageNewTeam()
        {
            InitializeComponent();
            contextTeam = new Team();
            DataContext = contextTeam;
            ComboDivisions.ItemsSource = App.DB.Division.ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.mainText = "New Team";
            App.IsLog = 3;
        }

        private void GotPhoto_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog() { Filter = "*.png; | *.png;" };
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                contextTeam.Logo = File.ReadAllBytes(dialog.FileName);
                DataContext = null;
                DataContext = contextTeam;
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (contextTeam.Coach != null && contextTeam.Abbr != null
                && ComboDivisions.SelectedIndex != -1 && contextTeam.TeamName != null
                && contextTeam.Logo != null)
            {
                contextTeam.Division = ComboDivisions.SelectedItem as Division;
                contextTeam.TeamId = App.DB.Team.ToList().Last().TeamId + 1;
                App.DB.Team.Add(contextTeam);
                App.DB.SaveChanges();
                NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
