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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();

            window3.Show();
            this.Hide();
        }
    }
}
