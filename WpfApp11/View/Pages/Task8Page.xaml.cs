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
    /// Логика взаимодействия для Task8Page.xaml
    /// </summary>
    public partial class Task8Page : Page
    {
        public Task8Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double a1, b1, c1, a2, b2, c2;

            a1 = Convert.ToDouble(Tba1.Text);
            b1 = Convert.ToDouble(Tbb1.Text);
            c1 = Convert.ToDouble(Tbc1.Text);
            a2 = Convert.ToDouble(Tba2.Text);
            b2 = Convert.ToDouble(Tbb2.Text);
            c2 = Convert.ToDouble(Tbc2.Text);

            Task8 task8 = new Task8(a1, b1, c1, a2, b2, c2);

            if (task8.Largest()) TbA.Text = "Треугольник a1,b1,c1 наибольший";
            else TbA.Text = "Треугольник a2,b2,c2 нибольший";

            Tba1.Text = string.Empty;
            Tbb1.Text = string.Empty;
            Tbc1.Text = string.Empty;
            Tba2.Text = string.Empty;
            Tbc2.Text = string.Empty;
            Tbb2.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task9Page());
        }
    }
}
