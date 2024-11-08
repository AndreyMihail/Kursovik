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

namespace Interface
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
        private void LoginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBlockPlaceholder.Visibility = string.IsNullOrEmpty(LoginTextBox.Text) ? Visibility.Visible : Visibility.Collapsed;
        }
        private void LoginTextBox_TextChanged1(object sender, TextChangedEventArgs e)
        {
            TextBlockPlaceholder1.Visibility = string.IsNullOrEmpty(LoginTextBox1.Text) ? Visibility.Visible : Visibility.Collapsed;
        }
        private void LoginTextBox_TextChanged2(object sender, TextChangedEventArgs e)
        {
            TextBlockPlaceholder2.Visibility = string.IsNullOrEmpty(LoginTextBox2.Text) ? Visibility.Visible : Visibility.Collapsed;
        }
        private void LoginTextBox_TextChanged3(object sender, TextChangedEventArgs e)
        {
            TextBlockPlaceholder3.Visibility = string.IsNullOrEmpty(LoginTextBox3.Text) ? Visibility.Visible : Visibility.Collapsed;
        }
        private void LoginTextBox_TextChanged4(object sender, TextChangedEventArgs e)
        {
            TextBlockPlaceholder4.Visibility = string.IsNullOrEmpty(LoginTextBox4.Text) ? Visibility.Visible : Visibility.Collapsed;
        }
        private void Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window1 window1 = new Window1();

            window1.Show();
            this.Hide();
        }
        private void Button_MouseLeftButtonDown1(object sender, MouseButtonEventArgs e)
        {
            Window4 window4 = new Window4();

            window4.Show();
            this.Hide();
        }
    }
}
