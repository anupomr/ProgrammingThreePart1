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

namespace WPFdesktopApplication
{
    /// <summary>
    /// Interaction logic for pgExpenseReportPage.xaml
    /// </summary>
    public partial class pgExpenseReportPage : Page
    {
        public pgExpenseReportPage()
        {
            InitializeComponent();
        }
        // Custom constructor to pass expense report data
        public pgExpenseReportPage(object data) : this()
        {
            // Bind to expense report data.
            this.DataContext = data;
        }

    }
}
