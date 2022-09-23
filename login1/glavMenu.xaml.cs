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

namespace login1
{
    /// <summary>
    /// Логика взаимодействия для glavMenu.xaml
    /// </summary>
    public partial class glavMenu : Window
    {
        public glavMenu()
        {
            InitializeComponent();
            glavFrame.Navigate(new raspis_page());
        }

        private void raspis_Click(object sender, RoutedEventArgs e)
        {
            glavFrame.Navigate(new raspis_page());
        }
    }
}
