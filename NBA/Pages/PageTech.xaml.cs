using NBA.Windows;
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
using System.Windows.Threading;

namespace NBA.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageTech.xaml
    /// </summary>
    public partial class PageTech : Page
    {
        DispatcherTimer dispatcherTimer;
        public PageTech()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.IsLog = 1;
            App.mainText = "Technical Administrator Menu";
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += RefreshTick;
            dispatcherTimer.Interval = TimeSpan.FromSeconds(2);
            dispatcherTimer.Start();
        }

        private void RefreshTick(object sender, EventArgs e)
        {
            MessageBox.Show("Manage Executions – Future Add-on", "The feature would be a future add-on to the current system.");
            dispatcherTimer.Stop();
        }

        private void ManageExecutions_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TeamReport_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageTeamReport());
        }
    }
}
