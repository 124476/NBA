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
    /// Логика взаимодействия для PageNewMatchup.xaml
    /// </summary>
    public partial class PageNewMatchup : Page
    {
        Matchup contextMatchup;
        public PageNewMatchup(Matchup matchup)
        {
            InitializeComponent();
            App.IsLog = 3;
            if (matchup.MatchupId == 0)
            {
                matchup.Season = App.DB.Season.ToList().Last();
                matchup.MatchupTypeId = 2;
                App.mainText = "Add a new matchup for regular season";
            }
            else
                App.mainText = "Update matchup for regular season";
            contextMatchup = matchup;
            ComboTeamAway.ItemsSource = App.DB.Team.ToList();
            ComboTeamHome.ItemsSource = App.DB.Team.ToList();
            DataContext = contextMatchup;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ComboTeamAway.SelectedIndex != -1 && ComboTeamHome.SelectedIndex != -1
                    && contextMatchup.Starttime != null && Date.SelectedDate != null)
                {
                    if (ComboTeamAway.SelectedIndex == ComboTeamHome.SelectedIndex)
                    {
                        MessageBox.Show("Don't Away != Home");
                        return;
                    }
                    contextMatchup.Starttime = Date.SelectedDate.Value + TimeSpan.Parse(Time.Text);
                    if (contextMatchup.MatchupId == 0)
                    {
                        App.DB.Matchup.Add(contextMatchup);
                    }
                    App.DB.SaveChanges();
                    NavigationService.GoBack();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
