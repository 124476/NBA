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
using Path = System.IO.Path;

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
            App.mainText = "Photos";
            TextOnly.Text = "1";
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
            TextOnly.Text = (dataId + 1).ToString();
            Refresh();
        }

        private void Refresh()
        {
            photos = App.DB.Pictures.ToList().Skip(dataId * showCount).Take(showCount).ToList();
            ListPhotos.ItemsSource = photos;
            totalCount = App.DB.Pictures.Count() / showCount;
            if (App.DB.Pictures.Count() % showCount != 0)
                totalCount++;
            TextAll.Text = $"Total {App.DB.Pictures.Count()} Photos, {photos.Count} Photos in one page, Total {totalCount} Pages";
        }

        private void UpAll_Click(object sender, RoutedEventArgs e)
        {
            dataId = totalCount - 1;
            TextOnly.Text = totalCount.ToString();
            Refresh();
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            if (dataId < totalCount - 1)
                dataId++;
            TextOnly.Text = (dataId + 1).ToString();
            Refresh();
        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            if (dataId > 0)
                dataId = 0;
            TextOnly.Text = "1";
            Refresh();
        }

        private void DownloadAll_Click(object sender, RoutedEventArgs e)
        {
            var dbDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Photos");
            if (!Directory.Exists(dbDir))
            {
                Directory.CreateDirectory(dbDir);
            }

            dbDir += "/";

            int txtFile = 0;
            foreach (var item in App.DB.Pictures.ToList())
            {
                var dialogFile = dbDir + txtFile + ".png";

                var file = File.Create(dialogFile);
                file.Close();

                File.WriteAllBytes(dialogFile, item.Img);
                txtFile++;
            }

            MessageBox.Show($"Все фотографии сохранены в {dbDir}");
        }

        private void TextOnly_SelectionChanged(object sender, RoutedEventArgs e)
        {
            try
            {
                int pageId = Int32.Parse(TextOnly.Text);
                if (0 < pageId && pageId <= totalCount)
                    dataId = pageId - 1;
                Refresh();
            }
            catch
            {

            }
        }
    }
}
