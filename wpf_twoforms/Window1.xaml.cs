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

namespace wpf_twoforms
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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsVisible)
            {
                return;
            }
            e.Cancel = true;
            Hide();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ((Owner as MainWindow).ActiveBox as TextBox).IsReadOnly = !((Owner as MainWindow).ActiveBox as TextBox).IsReadOnly;

            //изменение цвета фона textbox в зависимости от "IsReadOnly"
            if (((Owner as MainWindow).ActiveBox as TextBox).IsReadOnly)
            {
                ((Owner as MainWindow).ActiveBox as TextBox).Background = new SolidColorBrush(Color.FromRgb(0, 129, 16));
            }
            else
            {
                ((Owner as MainWindow).ActiveBox as TextBox).Background = new SolidColorBrush(Color.FromRgb(0, 198, 24));
            }             
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            button1_Click(sender,e);
            Close();
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                button0_Click(sender,e);
            }

            if (e.Key == Key.Escape)
            {
                Close();
            }
        }
    }
}
