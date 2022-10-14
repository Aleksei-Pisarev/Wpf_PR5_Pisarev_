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

namespace Wpf_PR5_Pisarev_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Okno2_Click(object sender, RoutedEventArgs e)
        {
            Okno2 okno2 = new Okno2();
            okno2.Show();
        }

        private void Button_Okno3_Click(object sender, RoutedEventArgs e)
        {
            Okno3 okno3 = new Okno3();
            okno3.Show();
        }

        private void Button_Okno4_Click(object sender, RoutedEventArgs e)
        {
            Okno4 okno4 = new Okno4();
            okno4.Show();
        }
        private void Button_Okno5_Click(object sender, RoutedEventArgs e)
        {
            Okno5 okno5 = new Okno5();
            okno5.Show();
        }
        private void Button_Okno6_Click(object sender, RoutedEventArgs e)
        {
            Okno6 okno6 = new Okno6();
            okno6.Show();
        }
    }
}
