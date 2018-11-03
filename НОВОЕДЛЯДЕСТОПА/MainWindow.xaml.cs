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

namespace НОВОЕДЛЯДЕСТОПА
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Получили сообщение для входа в систему!");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((char)e.Key == (char)Key.Enter)
            {
                TextBox text = (TextBox)sender;
                MessageBox.Show(text.Text);
            }
        }
    }
}
