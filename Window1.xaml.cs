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

namespace Interface
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void LoginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBlockPlaceholder.Visibility = string.IsNullOrEmpty(LoginTextBox.Text) ? Visibility.Visible : Visibility.Collapsed;
        }
        private void LoginTextBox_TextChanged1(object sender, TextChangedEventArgs e)
        {
            TextBlockPlaceholder1.Visibility = string.IsNullOrEmpty(LoginTextBox1.Text) ? Visibility.Visible : Visibility.Collapsed;
        }
        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow window = new MainWindow();

            window.Show();
            this.Hide();
        }
        private void Button_MouseLeftButtonDown1(object sender, MouseButtonEventArgs e)
        {
            Window4 window4 = new Window4();

            window4.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();

            window2.Show();
            this.Hide();
        }
    }
}
