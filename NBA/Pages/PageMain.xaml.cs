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
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        int ImgId;
        public PageMain()
        {
            InitializeComponent();
            Down.Content = "<";
            Up.Content = ">";
            ImgId = 1;
            Refresh();
        }

        private void Refresh()
        {
            ListPhotos.ItemsSource = App.DB.Pictures.Where(x => x.Id >= ImgId && x.Id < ImgId + 3).ToList();
        }

        private void VisitorBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageVisitorsMenu());
        }

        private void AdminBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            if (ImgId != 0)
            {
                ImgId -= 3;
                Refresh();
            }
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            ImgId += 3;
            ImgId = ImgId % App.DB.Pictures.Count();
            Refresh();
        }
    }
}
