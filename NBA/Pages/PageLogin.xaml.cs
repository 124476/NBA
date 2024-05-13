using NBA.Models;
using NBA.Properties;
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
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        bool IsAdmin;
        public PageLogin()
        {
            InitializeComponent();
            App.mainText = "Admin Login";
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var roleId = "";
            if (IsAdmin)
            {
                roleId = "1";
            }
            else
            {
                roleId = "2";
            };

            Admin admin = App.DB.Admin.FirstOrDefault(x => x.Role.RoleId == roleId && x.Jobnumber == Jobnumber.Text && x.Passwords == Password.Text);
            if (admin != null)
            {
                if (Checkremember.IsChecked == true)
                {
                    Settings.Default.Jobnumber = admin.Jobnumber;
                    Settings.Default.Password = admin.Passwords;
                }
                else
                {
                    Settings.Default.Jobnumber = "";
                    Settings.Default.Password = "";
                }
                Settings.Default.Save();
                App.IsLog = 1;
                if (IsAdmin)
                    NavigationService.Navigate(new PageAdmin());
                else
                    NavigationService.Navigate(new PageTech());
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.IsLog = 0;
            App.mainText = "Admin Login";
            var dialog = new OknoEventOrTech();
            if (dialog.ShowDialog().GetValueOrDefault())
                IsAdmin = true;
            else
                IsAdmin = false;
            Jobnumber.Text = Settings.Default.Jobnumber;
            Password.Text = Settings.Default.Password;
        }
    }
}
