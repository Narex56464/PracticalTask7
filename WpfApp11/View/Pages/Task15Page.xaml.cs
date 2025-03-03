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
using WpfApp11.Servers;
using WpfApp11.Utility.Tasks;

namespace WpfApp11.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task15Page.xaml
    /// </summary>
    public partial class Task15Page : Page
    {
        public Task15Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            int x0, y0, x1, y1;

            x0 = Convert.ToInt32(Tbx0.Text);
            y0 = Convert.ToInt32(Tby0.Text);
            x1 = Convert.ToInt32(Tbx1.Text);
            y1 = Convert.ToInt32(Tby1.Text);

            Task15 task15 = new Task15(x0, y0, x1, y1);

            TbA.Text = task15.Distance();

            Tbx0.Text = string.Empty;
            Tby0.Text = string.Empty;
            Tbx1.Text = string.Empty;
            Tby1.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task16Page());
        }
    }
}
