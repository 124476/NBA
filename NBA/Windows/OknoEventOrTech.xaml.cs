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
using System.Windows.Shapes;

namespace NBA.Windows
{
    /// <summary>
    /// Логика взаимодействия для OknoEventOrTech.xaml
    /// </summary>
    public partial class OknoEventOrTech : Window
    {
        public OknoEventOrTech()
        {
            InitializeComponent();
        }

        private void Eventbtn_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void TechBtn_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
