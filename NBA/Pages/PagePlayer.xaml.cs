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
    /// Логика взаимодействия для PagePlayer.xaml
    /// </summary>
    public partial class PagePlayer : Page
    {
        public PagePlayer(Player player)
        {
            InitializeComponent();
            App.mainText = "Player Detail";
            DataContext = player;
            try
            {
                var seasson = App.DB.Season.ToList().LastOrDefault();
                if (seasson != null)
                {
                    var seassonId = seasson.SeasonId;
                    var staticsNow = App.DB.PlayerStatistics.Where(x => x.PlayerId == player.PlayerId && x.Matchup.SeasonId == seassonId).ToList();
                    var statics = App.DB.PlayerStatistics.Where(x => x.PlayerId == player.PlayerId).ToList();
                    int ppgOnly = 0;
                    foreach(var item in staticsNow)
                    {
                        ppgOnly += item.Point;
                    }
                    ppgOnly = ppgOnly / staticsNow.Count;

                    int apgOnly = 0;
                    foreach (var item in staticsNow)
                    {
                        apgOnly += item.FieldGoalMade;
                    }
                    apgOnly = apgOnly / staticsNow.Count;

                    int rpgOnly = 0;
                    foreach (var item in staticsNow)
                    {
                        rpgOnly += item.FieldGoalMissed;
                    }
                    rpgOnly = rpgOnly / staticsNow.Count;

                    int ppg = 0;
                    foreach (var item in statics)
                    {
                        ppg += item.Point;
                    }
                    ppg = ppg / statics.Count;

                    int apg = 0;
                    foreach (var item in statics)
                    {
                        apg += item.FieldGoalMade;
                    }
                    apg = apg / statics.Count;

                    int rpg = 0;
                    foreach (var item in statics)
                    {
                        rpg += item.FieldGoalMissed;
                    }
                    rpg = rpg / statics.Count;

                    PPGOnly.Text = ppgOnly.ToString();
                    APGOnly.Text = apgOnly.ToString();
                    RPGOnly.Text = rpgOnly.ToString();
                    PPGAll.Text = ppg.ToString();
                    APGAll.Text = apg.ToString();
                    RPGAll.Text = rpg.ToString();
                }
                else
                {
                    PPGOnly.Text = "-";
                    APGOnly.Text = "-";
                    RPGOnly.Text = "-";
                    PPGAll.Text = "-";
                    APGAll.Text = "-";
                    RPGAll.Text = "-";
                }
            }
            catch
            {
                PPGOnly.Text = "-";
                APGOnly.Text = "-";
                RPGOnly.Text = "-";
                PPGAll.Text = "-";
                APGAll.Text = "-";
                RPGAll.Text = "-";
            }
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
