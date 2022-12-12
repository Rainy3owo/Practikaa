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

namespace WpfApp7
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Отель1 win1 = new Отель1();
            win1.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Экскурсионные_агенства win1 = new Экскурсионные_агенства();
            win1.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Рейсы win1 = new Рейсы();
            win1.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Информация_о_теристе win1 = new Информация_о_теристе();
            win1.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            расходы win1 = new расходы();
            win1.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Экскурсии win1 = new Экскурсии();
            win1.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            доходы win1 = new доходы();
            win1.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Отель1 win1 = new Отель1();
            win1.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Экскурсионные_агенства win1 = new Экскурсионные_агенства();
            win1.Show();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Рейсы win1 = new Рейсы();
            win1.Show();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Информация_о_теристе win1 = new Информация_о_теристе();
            win1.Show();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            расходы win1 = new расходы();
            win1.Show();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Экскурсии win1 = new Экскурсии();
            win1.Show();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            доходы win1 = new доходы();
            win1.Show();
        }
    }
}
