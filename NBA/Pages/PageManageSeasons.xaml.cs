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
    /// Логика взаимодействия для PageManageSeasons.xaml
    /// </summary>
    public partial class PageManageSeasons : Page
    {
        public PageManageSeasons()
        {
            InitializeComponent();
            var seassons = App.DB.Season.ToList();
            seassons.Insert(0, new Season()
            {
                Name = "All"
            });
            PoiskCombo.ItemsSource = seassons;
            var matchs = App.DB.MatchupType.ToList();
            matchs.Insert(0, new MatchupType()
            {
                Name = "All"
            });
            ComboMath.ItemsSource = matchs;
            Refresh();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.IsLog = 2;
            App.mainText = "Manage Seasons";
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            var matchups = App.DB.Matchup.ToList();
            var season = (PoiskCombo.SelectedItem as Season);
            var match = (ComboMath.SelectedItem as MatchupType);

            if (PoiskCombo.SelectedIndex != -1 && season.Name != "All")
                matchups = matchups.Where(x => x.SeasonId == season.SeasonId).ToList();

            if (ComboMath.SelectedIndex != -1 && match.Name != "All")
                matchups = matchups.Where(x => x.MatchupTypeId == match.MatchupTypeId).ToList();

            List<StaticsMatch> staticsMatches = new List<StaticsMatch>();
            foreach(var item in matchups)
            {
                var stat = staticsMatches.FirstOrDefault(x => x.Season == item.Season.Name && x.MatchupType == item.MatchupType.Name);
                if (stat != null)
                {
                    stat.Number += 1;
                }
                else
                {
                    staticsMatches.Add(new StaticsMatch()
                    {
                        Number = 1,
                        MatchupType = item.MatchupType.Name,
                        Season = item.Season.Name
                    });
                }
            }

            DataOne.ItemsSource = staticsMatches;
            DataTwo.ItemsSource = matchups;
        }
    }
}
