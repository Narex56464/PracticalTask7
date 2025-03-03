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
    /// Логика взаимодействия для Task16Page.xaml
    /// </summary>
    public partial class Task16Page : Page
    {
        public Task16Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, y, r, R;

            x = Convert.ToDouble(Tbx.Text);
            y = Convert.ToDouble(Tby.Text);
            r = Convert.ToDouble(Tbr.Text);
            R = Convert.ToDouble(TbR.Text);

            Task16 task16 = new Task16(x, y, r, R);

            if (task16.Exp()) TbA.Text = "Точка А лежит внутри тора";
            else TbA.Text = "Точка А не лежит внутри тора";

            Tbx.Text = string.Empty;
            Tby.Text = string.Empty;
            TbR.Text = string.Empty;
            Tbr.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task17Page());
        }
    }
}
