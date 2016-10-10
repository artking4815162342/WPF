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

namespace wpf_twoforms
{

    public partial class MainWindow : Window
    {
        private Window1 window = new Window1();
        public Control ActiveBox;

        public MainWindow()
        {
            InitializeComponent();
            textBox0.Focus();
            ActiveBox = textBox0;      
        }

        private void label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            window.Owner = this;
            window.ShowDialog();
        }

        private void textBox0_GotFocus(object sender, RoutedEventArgs e)
        {
            ActiveBox = textBox0;
        }

        private void textBox1_GotFocus(object sender, RoutedEventArgs e)
        {
            ActiveBox = textBox1;
        }

        private void textBox2_GotFocus(object sender, RoutedEventArgs e)
        {
            ActiveBox = textBox2;
        }
    }
}
