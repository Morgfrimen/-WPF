using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text=="admin" && Password.Password=="admin")
            {
                label.Content = (string.Format("Здравствуйте {0} !\nЗапускаем главный экран...",Login.Text));
                windows.Width = 650;
                windows.Height = 650;
                Thread.Sleep(500);
                windows.Width = 850;
                windows.Height = 850;
                windows.WindowStartupLocation = WindowStartupLocation.Manual;
                ЛогинПароль.Visibility = Visibility.Hidden;
                button.Visibility = Visibility.Hidden;
                Закрытие.Visibility = Visibility.Visible;
               // Thread.Sleep(500);

            }
            else
            {
                label.Content = "Вы незарегистрированны!\nВыполните регистрацию для продолжения!";
                Login.Text = "";
                Password.Password = "";
                Login.Focus();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
