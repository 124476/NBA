using LiveCharts.Wpf;
using LiveCharts;
using NBA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Serialization;
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
using Microsoft.Office.Interop.Excel;
using Page = System.Windows.Controls.Page;


namespace NBA.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePlayer.xaml
    /// </summary>
    public partial class PagePlayer : Page
    {
        int graficId;
        Player contextPlayer;
        public PagePlayer(Player player)
        {
            InitializeComponent();
            contextPlayer = player;
            graficId = 0;

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
            Refresh();
            POINTS.Background = Brushes.LightBlue;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void POINTS_Click(object sender, RoutedEventArgs e)
        {
            graficId = 0;
            Refresh();
            POINTS.Background = Brushes.LightBlue;
        }

        private void REBOUNDS_Click(object sender, RoutedEventArgs e)
        {
            graficId = 1;
            Refresh();
            REBOUNDS.Background = Brushes.LightBlue;
        }

        private void ASSISTS_Click(object sender, RoutedEventArgs e)
        {
            graficId = 2;
            Refresh();
            ASSISTS.Background = Brushes.LightBlue;
        }

        private void STEALS_Click(object sender, RoutedEventArgs e)
        {
            graficId = 3;
            Refresh();
            STEALS.Background = Brushes.LightBlue;
        }

        private void BLOCKS_Click(object sender, RoutedEventArgs e)
        {
            graficId = 4;
            Refresh();
            BLOCKS.Background = Brushes.LightBlue;
        }

        private void Refresh()
        {
            var statics = App.DB.PlayerStatistics.ToList();

            if (DateStart.SelectedDate != null)
                statics = statics.Where(x => x.Matchup.Starttime >= DateStart.SelectedDate).ToList();

            if (DateEnd.SelectedDate != null)
                statics = statics.Where(x => x.Matchup.Starttime <= DateEnd.SelectedDate).ToList();

            statics = statics.Where(x => x.PlayerId == contextPlayer.PlayerId).ToList();

            var counts = new ChartValues<double>();
            var nameGraf = "";
            double sum = 0;

            if (graficId == 0)
            {
                foreach(var item in statics)
                {    
                    counts.Add(item.Point);
                    sum += item.Point; 
                }
                try
                {
                    sum = sum / statics.Count;
                }
                catch
                {

                }
                TextThis.Text = "Points";
                nameGraf = "points";
            }
            if (graficId == 1)
            {
                foreach (var item in statics)
                {
                    counts.Add(item.Rebound);
                    sum += item.Rebound;
                }
                try
                {
                    sum = sum / statics.Count;
                }
                catch
                {

                }
                TextThis.Text = "Rebounds";
                nameGraf = "rebounds";
            }
            if (graficId == 2)
            {
                foreach (var item in statics)
                {
                    counts.Add(item.Assist);
                    sum += item.Assist;
                }
                try
                {
                    sum = sum / statics.Count;
                }
                catch
                {

                }
                TextThis.Text = "Assists";
                nameGraf = "assists";
            }
            if (graficId == 3)
            {
                foreach (var item in statics)
                {
                    counts.Add(item.Steal);
                    sum += item.Steal;
                }
                try
                {
                    sum = sum / statics.Count;
                }
                catch
                {

                }
                TextThis.Text = "Steals";
                nameGraf = "steals";
            }
            if (graficId == 4)
            {
                foreach (var item in statics)
                {
                    counts.Add(item.Block);
                    sum += item.Block;
                }
                try
                {
                    sum = sum / statics.Count;
                }
                catch
                {

                }
                TextThis.Text = "Blocks";
                nameGraf = "blocks";
            }

            var seriescollection = new LiveCharts.SeriesCollection()
            {
                new LineSeries()
                {
                    Values = counts,
                    Fill = null,
                }
            };

            Cartes.Series = null;
            Cartes.Series = seriescollection;
            TextOnly.Text = $"The average of {nameGraf}:";
            TextAll.Text = sum.ToString();

            REBOUNDS.Background = Brushes.LightGray;
            POINTS.Background = Brushes.LightGray;
            STEALS.Background = Brushes.LightGray;
            BLOCKS.Background = Brushes.LightGray;
            ASSISTS.Background = Brushes.LightGray;
        }
    }
}
