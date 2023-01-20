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

namespace WPF_Money_Calculate
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

        private void calculate_day_Click(object sender, RoutedEventArgs e)
        {
            int day = int.Parse(wishlist.Text) / (int.Parse(income.Text) - int.Parse(expenses.Text));
            days.Text = day.ToString();
            //income.Text = "รายได้";
            //expenses.Text = "รายได้";
            //wishlist.Text = "สิ่งที่อยากได้";
            //days.Text = "วัน";
        }
    }
}
