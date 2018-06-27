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

namespace WpfDataBinding
{
    /// <summary>
    /// Interaction logic for winWithoutDataBinding.xaml
    /// </summary>
    public partial class winWithoutDataBinding : Window
    {
        public winWithoutDataBinding()
        {
            InitializeComponent();
        }

        private void MyTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(MyTextBox.Text);
                MySlider.Value = value;
            }
            catch
            {
                MessageBox.Show("Cannot convert " + MyTextBox.Text + " to a value");
            }

        }

        private void MyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                try
                {
                    int value = Convert.ToInt32(MyTextBox.Text);
                    MySlider.Value = value;
                }
                catch
                {
                    MessageBox.Show("Cannot convert " + MyTextBox.Text + " to a value");
                }
            }
        }

        private void MySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MyTextBox.Text = MySlider.Value + "";
        }
    }
}
