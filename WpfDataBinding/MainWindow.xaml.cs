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

namespace WpfDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonHandler(object sender, RoutedEventArgs e)
        {
            FrameworkElement fe = e.Source as FrameworkElement;
            switch (fe.Name)
            {
                case "one_way_to_source":
                    new winOneWayToSource().ShowDialog();
                    break;
                case "two_way":
                    new winTwoWay().ShowDialog();
                    break;
                case "one_way_to_target":
                    new winOneWayToTarget().ShowDialog();
                    break;
                case "one_time_to_target":
                    new winOneTimeToTarget().ShowDialog();
                    break;
                case "via_code":
                    new winWithoutDataBinding().ShowDialog();
                    break;
            }
        }
    }
}
