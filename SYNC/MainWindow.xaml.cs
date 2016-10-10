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

namespace SYNC
{
    //как убрать иконку
    //как всё увеличить в масштабе на процент
    public partial class MainWindow : Window
    {
        Window1 form2 = new Window1();

        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 7; i++)
            {
                (FindName("mTextBox" + i.ToString()) as TextBox).TextChanged += changeNum;
            }
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            form2.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            form2.Owner = this;
        }

        private void changeNum(object sender, TextChangedEventArgs e)
        {
            var tb = (sender as TextBox);
            int result = 0;
            bool isParse = int.TryParse(tb.Text, out result);
            var findControl = (form2.FindName("slider" + tb.Name[tb.Name.Length - 1]) as Slider);

            if (isParse)
            {
                findControl.Value = result;
            }
            else
            {
                findControl.Value = 0;
            }        
        } 
    }
}
