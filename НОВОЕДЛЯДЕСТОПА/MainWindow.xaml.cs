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
        void Messages()
        {
            label.Content = "удалось";
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text=="1" && Password.Password=="1")
            {
                label.Content = string.Format("Здраствуйсте, {0}!",Login.Text);
                label.DataContext = "Внесено изменение";
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

        private void label_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            ЛогинПароль.Visibility = Visibility.Collapsed;
            button.Visibility = Visibility.Collapsed;
            label.HorizontalAlignment = HorizontalAlignment.Center;
            for(int i = 0; i <= 100; i += 15)
            {
                Thread.Sleep(25);
                windows.Height += i;
                windows.Width += i;
            }
            Закрытие.Visibility = Visibility.Visible;
        }
    }
}
