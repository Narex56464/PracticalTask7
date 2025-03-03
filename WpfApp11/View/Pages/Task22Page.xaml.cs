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
    /// Логика взаимодействия для Task22Page.xaml
    /// </summary>
    public partial class Task22Page : Page
    {
        public Task22Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double v1, m1, v2, m2;

            v1 = Convert.ToDouble(Tbv1.Text);
            m1 = Convert.ToDouble(Tbm1.Text);
            v2 = Convert.ToDouble(Tbv2.Text);
            m2 = Convert.ToDouble(Tbm2.Text);

            Task22 task22 = new Task22(v1, m1, v2, m2);

            if (task22.More()) TbA.Text = "Первый тело будет больше второго";
            else TbA.Text = "Второе тело будет больше первого";

            Tbv1.Text = string.Empty;
            Tbm1.Text = string.Empty;
            Tbv2.Text = string.Empty;
            Tbm2.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task23Page());
        }
    }
}
