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
    /// Логика взаимодействия для Task9Page.xaml
    /// </summary>
    public partial class Task9Page : Page
    {
        public Task9Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double a, r;

            a = Convert.ToDouble(Tba.Text);
            r = Convert.ToDouble(Tbr.Text);

            Task9 task9 = new Task9(a, r);

            if (task9.More()) TbA.Text = "Площадь квадрата больше";
            else TbA.Text = "Площадь окружности больше";

            Tba.Text = string.Empty;
            Tbr.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task10Page());
        }
    }
}
