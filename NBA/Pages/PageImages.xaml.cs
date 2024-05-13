using Microsoft.Win32;
using NBA.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
    /// Логика взаимодействия для PageImages.xaml
    /// </summary>
    public partial class PageImages : Page
    {
        int showCount = 12;
        int dataId;
        List<Pictures> photos;
        int totalCount;
        public PageImages()
        {
            InitializeComponent();
            dataId = 0;
            Refresh();
        }

        private void Image_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            var dialog = new SaveFileDialog() { Filter = "*.png; | *.png;" };
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                var file = File.Create(dialog.FileName);
                file.Close();

                var photo = (sender as Image).DataContext as Pictures;
                File.WriteAllBytes(dialog.FileName, photo.Img);
            }
        }

        private void DownAll_Click(object sender, RoutedEventArgs e)
        {
            dataId = 0;
            Refresh();
        }

        private void Refresh()
        {
            photos = App.DB.Pictures.ToList().Skip(dataId * showCount).Take(showCount).ToList();
            ListPhotos.ItemsSource = photos;
            totalCount = photos.Count / showCount;
            if (photos.Count % showCount != 0)
                totalCount++;
            TextOnly.Text = (dataId + 1).ToString();
            TextAll.Text = $"Total {App.DB.Pictures.Count()} Photos, {photos.Count} Photos in one page, Total {totalCount} Pages";
        }

        private void UpAll_Click(object sender, RoutedEventArgs e)
        {
            dataId = totalCount;
            Refresh();
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            if (dataId < totalCount)
                dataId++;
            Refresh();
        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            if (dataId > 0)
                dataId = 0;
            Refresh();
        }

        private void DownloadAll_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
