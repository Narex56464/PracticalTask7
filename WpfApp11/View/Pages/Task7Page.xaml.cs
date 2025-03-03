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
    /// Логика взаимодействия для Task7Page.xaml
    /// </summary>
    public partial class Task7Page : Page
    {
        public Task7Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double x, y, r;

            x = Convert.ToDouble(Tbx.Text);
            y = Convert.ToDouble(Tby.Text);
            r = Convert.ToDouble(Tbr.Text);

            Task7 task7 = new Task7(x, y, r);

            if (task7.Radius()) TbA.Text = "Точка А лежит в радиусе R";
            else TbA.Text = "Точка А не лежит в радиусе R";

            Tbx.Text = string.Empty;
            Tby.Text = string.Empty;
            Tbr.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task8Page());
        }
    }
}
