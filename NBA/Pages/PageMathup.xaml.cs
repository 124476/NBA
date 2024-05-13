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
    /// Логика взаимодействия для PageMathup.xaml
    /// </summary>
    public partial class PageMathup : Page
    {
        List<ResultMath> resultMaths;
        Matchup contextMath;
        public PageMathup(Matchup matchup)
        {
            InitializeComponent();
            App.mainText = "Mathup Detail";
            DataContext = matchup;
            contextMath = matchup;
            resultMaths = new List<ResultMath>();
            int tm1;
            int tm2;
            int tm3;
            int tm4;

            var tim1 = App.DB.MatchupDetail.FirstOrDefault(x => x.MatchupId == matchup.MatchupId && x.Quarter == 1);
            if (tim1 != null)
            {
                tm1 = App.DB.MatchupDetail.FirstOrDefault(x => x.MatchupId == matchup.MatchupId && x.Quarter == 1).Team_Home_Score;
            }
            else
            {
                tm1 = 0;
            }

            var tim2 = App.DB.MatchupDetail.FirstOrDefault(x => x.MatchupId == matchup.MatchupId && x.Quarter == 2);
            if (tim1 != null)
            {
                tm2 = App.DB.MatchupDetail.FirstOrDefault(x => x.MatchupId == matchup.MatchupId && x.Quarter == 2).Team_Home_Score;
            }
            else
            {
                tm2 = 0;
            }

            var tim3 = App.DB.MatchupDetail.FirstOrDefault(x => x.MatchupId == matchup.MatchupId && x.Quarter == 31);
            if (tim1 != null)
            {
                tm3 = App.DB.MatchupDetail.FirstOrDefault(x => x.MatchupId == matchup.MatchupId && x.Quarter == 3).Team_Home_Score;
            }
            else
            {
                tm3 = 0;
            }

            var tim4 = App.DB.MatchupDetail.FirstOrDefault(x => x.MatchupId == matchup.MatchupId && x.Quarter == 4);
            if (tim4 != null)
            {
                tm4 = App.DB.MatchupDetail.FirstOrDefault(x => x.MatchupId == matchup.MatchupId && x.Quarter == 4).Team_Home_Score;
            }
            else
            {
                tm4 = 0;
            }

            AddNewResult(matchup.Team.Abbr, matchup.Team_Home_Score, 0, tm1, tm2, tm3, tm4);

            tim1 = App.DB.MatchupDetail.FirstOrDefault(x => x.MatchupId == matchup.MatchupId && x.Quarter == 1);
            if (tim1 != null)
            {
                tm1 = App.DB.MatchupDetail.FirstOrDefault(x => x.MatchupId == matchup.MatchupId && x.Quarter == 1).Team_Away_Score;
            }
            else
            {
                tm1 = 0;
            }

            tim2 = App.DB.MatchupDetail.FirstOrDefault(x => x.MatchupId == matchup.MatchupId && x.Quarter == 2);
            if (tim1 != null)
            {
                tm2 = App.DB.MatchupDetail.FirstOrDefault(x => x.MatchupId == matchup.MatchupId && x.Quarter == 2).Team_Away_Score;
            }
            else
            {
                tm2 = 0;
            }

            tim3 = App.DB.MatchupDetail.FirstOrDefault(x => x.MatchupId == matchup.MatchupId && x.Quarter == 31);
            if (tim1 != null)
            {
                tm3 = App.DB.MatchupDetail.FirstOrDefault(x => x.MatchupId == matchup.MatchupId && x.Quarter == 3).Team_Away_Score;
            }
            else
            {
                tm3 = 0;
            }

            tim4 = App.DB.MatchupDetail.FirstOrDefault(x => x.MatchupId == matchup.MatchupId && x.Quarter == 4);
            if (tim4 != null)
            {
                tm4 = App.DB.MatchupDetail.FirstOrDefault(x => x.MatchupId == matchup.MatchupId && x.Quarter == 4).Team_Away_Score;
            }
            else
            {
                tm4 = 0;
            }

            AddNewResult(matchup.Team1.Abbr, matchup.Team_Away_Score, 0, tm1, tm2, tm3, tm4);

            DataMaths.ItemsSource = resultMaths;

            List<ResultOneMath> resultOneMaths = new List<ResultOneMath>();

            int sum = 0;
            foreach (var item in App.DB.PlayerStatistics.Where(x => x.MatchupId == matchup.MatchupId && x.Team.TeamId == matchup.Team.TeamId).ToList())
            {
                sum += item.FieldGoalMade;
            }

            int sumTwo = 0;
            foreach (var item in App.DB.PlayerStatistics.Where(x => x.MatchupId == matchup.MatchupId && x.Team.TeamId == matchup.Team.TeamId).ToList())
            {
                sumTwo += item.FieldGoalMissed;
            }

            int sum2 = 0;
            foreach (var item in App.DB.PlayerStatistics.Where(x => x.MatchupId == matchup.MatchupId && x.Team.TeamId == matchup.Team1.TeamId).ToList())
            {
                sum2 += item.FieldGoalMade;
            }

            int sumTwo2 = 0;
            foreach (var item in App.DB.PlayerStatistics.Where(x => x.MatchupId == matchup.MatchupId && x.Team.TeamId == matchup.Team1.TeamId).ToList())
            {
                sumTwo2 += item.FieldGoalMissed;
            }

            resultOneMaths.Add(new ResultOneMath()
            {
                Name = "FG Made-Attempled",
                TextHome = sum.ToString() + " - " + sumTwo.ToString(),
                TextAway = sum2.ToString() + " - " + sumTwo2.ToString(),
            });

            sum = 0;
            foreach (var item in App.DB.PlayerStatistics.Where(x => x.MatchupId == matchup.MatchupId && x.Team.TeamId == matchup.Team.TeamId).ToList())
            {
                sum += item.C3_PointFieldGoalMade;
            }

            sumTwo = 0;
            foreach (var item in App.DB.PlayerStatistics.Where(x => x.MatchupId == matchup.MatchupId && x.Team.TeamId == matchup.Team.TeamId).ToList())
            {
                sumTwo += item.C3_PointFieldGoalMissed;
            }

            sum2 = 0;
            foreach (var item in App.DB.PlayerStatistics.Where(x => x.MatchupId == matchup.MatchupId && x.Team.TeamId == matchup.Team1.TeamId).ToList())
            {
                sum2 += item.C3_PointFieldGoalMade;
            }

            sumTwo2 = 0;
            foreach (var item in App.DB.PlayerStatistics.Where(x => x.MatchupId == matchup.MatchupId && x.Team.TeamId == matchup.Team1.TeamId).ToList())
            {
                sumTwo2 += item.C3_PointFieldGoalMissed;
            }

            resultOneMaths.Add(new ResultOneMath()
            {
                Name = "3PT Made-Attempted",
                TextHome = sum.ToString() + " - " + sumTwo.ToString(),
                TextAway = sum2.ToString() + " - " + sumTwo2.ToString(),
            });


            sum = 0;
            foreach (var item in App.DB.PlayerStatistics.Where(x => x.MatchupId == matchup.MatchupId && x.Team.TeamId == matchup.Team.TeamId).ToList())
            {
                sum += item.FreeThrowMade;
            }

            sumTwo = 0;
            foreach (var item in App.DB.PlayerStatistics.Where(x => x.MatchupId == matchup.MatchupId && x.Team.TeamId == matchup.Team.TeamId).ToList())
            {
                sumTwo += item.FreeThrowMissed;
            }

            sum2 = 0;
            foreach (var item in App.DB.PlayerStatistics.Where(x => x.MatchupId == matchup.MatchupId && x.Team.TeamId == matchup.Team1.TeamId).ToList())
            {
                sum2 += item.FreeThrowMade;
            }

            sumTwo2 = 0;
            foreach (var item in App.DB.PlayerStatistics.Where(x => x.MatchupId == matchup.MatchupId && x.Team.TeamId == matchup.Team1.TeamId).ToList())
            {
                sumTwo2 += item.FreeThrowMissed;
            }

            resultOneMaths.Add(new ResultOneMath()
            {
                Name = "FT Made-Attempled",
                TextHome = sum.ToString() + " - " + sumTwo.ToString(),
                TextAway = sum2.ToString() + " - " + sumTwo2.ToString(),
            });

            sum = 0;
            foreach (var item in App.DB.PlayerStatistics.Where(x => x.MatchupId == matchup.MatchupId && x.Team.TeamId == matchup.Team.TeamId).ToList())
            {
                sum += item.Rebound;
            }

            sum2 = 0;
            foreach (var item in App.DB.PlayerStatistics.Where(x => x.MatchupId == matchup.MatchupId && x.Team.TeamId == matchup.Team1.TeamId).ToList())
            {
                sum2 += item.Rebound;
            }

            resultOneMaths.Add(new ResultOneMath()
            {
                Name = "Rebounds",
                TextHome = sum.ToString(),
                TextAway = sum2.ToString(),
            });

            sum = 0;
            foreach (var item in App.DB.PlayerStatistics.Where(x => x.MatchupId == matchup.MatchupId && x.Team.TeamId == matchup.Team.TeamId).ToList())
            {
                sum += item.Assist;
            }

            sum2 = 0;
            foreach (var item in App.DB.PlayerStatistics.Where(x => x.MatchupId == matchup.MatchupId && x.Team.TeamId == matchup.Team1.TeamId).ToList())
            {
                sum2 += item.Assist;
            }

            resultOneMaths.Add(new ResultOneMath()
            {
                Name = "Assists",
                TextHome = sum.ToString(),
                TextAway = sum2.ToString(),
            });

            sum = 0;
            foreach (var item in App.DB.PlayerStatistics.Where(x => x.MatchupId == matchup.MatchupId && x.Team.TeamId == matchup.Team.TeamId).ToList())
            {
                sum += item.Steal;
            }

            sum2 = 0;
            foreach (var item in App.DB.PlayerStatistics.Where(x => x.MatchupId == matchup.MatchupId && x.Team.TeamId == matchup.Team1.TeamId).ToList())
            {
                sum2 += item.Steal;
            }

            resultOneMaths.Add(new ResultOneMath()
            {
                Name = "Steals",
                TextHome = sum.ToString(),
                TextAway = sum2.ToString(),
            });

            sum = 0;
            foreach (var item in App.DB.PlayerStatistics.Where(x => x.MatchupId == matchup.MatchupId && x.Team.TeamId == matchup.Team.TeamId).ToList())
            {
                sum += item.Block;
            }

            sum2 = 0;
            foreach (var item in App.DB.PlayerStatistics.Where(x => x.MatchupId == matchup.MatchupId && x.Team.TeamId == matchup.Team1.TeamId).ToList())
            {
                sum2 += item.Block;
            }

            resultOneMaths.Add(new ResultOneMath()
            {
                Name = "Blocks",
                TextHome = sum.ToString(),
                TextAway = sum2.ToString(),
            });

            sum = 0;
            foreach (var item in App.DB.PlayerStatistics.Where(x => x.MatchupId == matchup.MatchupId && x.Team.TeamId == matchup.Team.TeamId).ToList())
            {
                sum += item.Turnover;
            }

            sum2 = 0;
            foreach (var item in App.DB.PlayerStatistics.Where(x => x.MatchupId == matchup.MatchupId && x.Team.TeamId == matchup.Team1.TeamId).ToList())
            {
                sum2 += item.Turnover;
            }

            resultOneMaths.Add(new ResultOneMath()
            {
                Name = "Turnovers",
                TextHome = sum.ToString(),
                TextAway = sum2.ToString(),
            });

            DataTeamStatus.ItemsSource = resultOneMaths;
            PoiskCombo.ItemsSource = new string[] { "All", "1st", "2nd", "3rd", "4th" };
            ListTeam.ItemsSource = App.DB.PlayerInTeam.Where(x => x.Team.TeamId == matchup.Team.TeamId).Select(x => x.Player).ToList().Distinct().Take(5).ToList();
            ListTeam1.ItemsSource = App.DB.PlayerInTeam.Where(x => x.Team.TeamId == matchup.Team1.TeamId).Select(x => x.Player).ToList().Distinct().Take(5).ToList();
        }

        private void AddNewResult(string tmAbbr, int tmAll, int tmQT, int tm1, int tm2, int tm3, int tm4)
        {
            resultMaths.Add(new ResultMath()
            {
                TeamAbbr = tmAbbr,
                TimeAll = tmAll,
                Time1 = tm1,
                Time2 = tm2,
                Time3 = tm3,
                Time4 = tm4,
                TimeQT = tmQT.ToString(),
            });

            DataTeamStatus.Visibility = Visibility.Visible;
            GridTwo.Visibility = Visibility.Collapsed;
            GridTree.Visibility = Visibility.Collapsed;
        }

        private void TeamStatus_Click(object sender, RoutedEventArgs e)
        {
            DataTeamStatus.Visibility = Visibility.Visible;
            GridTwo.Visibility = Visibility.Collapsed;
            GridTree.Visibility = Visibility.Collapsed;
        }

        private void ShortChart_Click(object sender, RoutedEventArgs e)
        {
            DataTeamStatus.Visibility = Visibility.Collapsed;
            GridTwo.Visibility = Visibility.Visible;
            GridTree.Visibility = Visibility.Collapsed;
        }

        private void Log_Click(object sender, RoutedEventArgs e)
        {
            DataTeamStatus.Visibility = Visibility.Collapsed;
            GridTwo.Visibility = Visibility.Collapsed;
            GridTree.Visibility = Visibility.Visible;
        }


        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Photo.Source = (BitmapSource)PhotoOk.Source;
            PhotoOne.Source = (BitmapSource)PhotoOkOne.Source;
            DataPlayers.ItemsSource = App.DB.MatchupLog.Where(x => x.MatchupId == contextMath.MatchupId).ToList();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            if (PoiskCombo.SelectedIndex == 0 || PoiskCombo.SelectedIndex == -1)
            {
                DataPlayers.ItemsSource = App.DB.MatchupLog.Where(x => x.MatchupId == contextMath.MatchupId).ToList();
            }
            if (PoiskCombo.SelectedIndex == 1)
            {
                DataPlayers.ItemsSource = App.DB.MatchupLog.Where(x => x.MatchupId == contextMath.MatchupId && x.Quarter == 1).ToList();
            }
            if (PoiskCombo.SelectedIndex == 2)
            {
                DataPlayers.ItemsSource = App.DB.MatchupLog.Where(x => x.MatchupId == contextMath.MatchupId && x.Quarter == 2).ToList();
            }
            if (PoiskCombo.SelectedIndex == 3)
            {
                DataPlayers.ItemsSource = App.DB.MatchupLog.Where(x => x.MatchupId == contextMath.MatchupId && x.Quarter == 3).ToList();
            }
            if (PoiskCombo.SelectedIndex == 4)
            {
                DataPlayers.ItemsSource = App.DB.MatchupLog.Where(x => x.MatchupId == contextMath.MatchupId && x.Quarter == 4).ToList();
            }
        }
    }
}
