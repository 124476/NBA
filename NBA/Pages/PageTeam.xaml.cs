﻿using NBA.Models;
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
    /// Логика взаимодействия для PageTeam.xaml
    /// </summary>
    public partial class PageTeam : Page
    {
        public PageTeam()
        {
            InitializeComponent();
            App.mainText = "Teams Main";
            TextOne.Text = "Atlantic";
            TextTwo.Text = "Central";
            TextTree.Text = "Southeast";
            ListOne.ItemsSource = App.DB.Team.Where(x => x.DivisionId == 3).ToList();
            ListTwo.ItemsSource = App.DB.Team.Where(x => x.DivisionId == 2).ToList();
            ListTree.ItemsSource = App.DB.Team.Where(x => x.DivisionId == 1).ToList();
        }

        private void Eastern_Click(object sender, RoutedEventArgs e)
        {
            TextOne.Text = "Atlantic";
            TextTwo.Text = "Central";
            TextTree.Text = "Southeast";
            ListOne.ItemsSource = App.DB.Team.Where(x => x.DivisionId == 3).ToList();
            ListTwo.ItemsSource = App.DB.Team.Where(x => x.DivisionId == 2).ToList();
            ListTree.ItemsSource = App.DB.Team.Where(x => x.DivisionId == 1).ToList();
        }

        private void Western_Click(object sender, RoutedEventArgs e)
        {
            TextOne.Text = "Northwest";
            TextTwo.Text = "Pacific";
            TextTree.Text = "Southwest";
            ListOne.ItemsSource = App.DB.Team.Where(x => x.DivisionId == 5).ToList();
            ListTwo.ItemsSource = App.DB.Team.Where(x => x.DivisionId == 6).ToList();
            ListTree.ItemsSource = App.DB.Team.Where(x => x.DivisionId == 4).ToList();
        }

        private void FirstLineup_Click(object sender, RoutedEventArgs e)
        {
            Team team = (sender as Hyperlink).DataContext as Team;
            if (team != null)
            {
                NavigationService.Navigate(new PageDetail(team, 3));
            }
        }

        private void Matchup_Click(object sender, RoutedEventArgs e)
        {
            Team team = (sender as Hyperlink).DataContext as Team;
            if (team != null)
            {
                NavigationService.Navigate(new PageDetail(team, 2));
            }
        }

        private void Roster_Click(object sender, RoutedEventArgs e)
        {
            Team team = (sender as Hyperlink).DataContext as Team;
            if (team != null)
            {
                NavigationService.Navigate(new PageDetail(team, 1));
            }
        }
    }
}
