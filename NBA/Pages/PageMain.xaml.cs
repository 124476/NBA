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
        int imageStep;
        public PageMain()
        {
            InitializeComponent();
            Down.Content = "<";
            Up.Content = ">";
            imageStep = 0;
            Refresh();
        }

        private void Refresh()
        {
            var photos = App.DB.Pictures.ToList();
          
            photos.AddRange(App.DB.Pictures.ToList());
            
            photos = photos.Skip(imageStep).Take(3).ToList();
            ListPhotos.ItemsSource = photos;
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
            imageStep -= 3;
            if (imageStep < 0)
                imageStep = App.DB.Pictures.Count() - 3;
            Refresh();
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            imageStep += 3;
            if (imageStep > App.DB.Pictures.Count() - 3)
                imageStep = 0;

            Refresh();
        }
    }
}
