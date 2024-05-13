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

namespace NBA.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageTech.xaml
    /// </summary>
    public partial class PageTech : Page
    {
        public PageTech()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.IsLog = 1;
            App.mainText = "Technical Administrator Menu";
            var dialog = new OknoManage();
            dialog.ShowDialog();
        }

        private void ManageExecutions_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TeamReport_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
