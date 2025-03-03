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
    /// Логика взаимодействия для Task20Page.xaml
    /// </summary>
    public partial class Task20Page : Page
    {
        public Task20Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double speed1, speed2;

            speed1 = Convert.ToDouble(Tbv.Text);
            speed2 = Convert.ToDouble(Tbt.Text) / 60;

            Task20 task20 = new Task20(speed1, speed2);

            if (task20.Exp()) TbA.Text = "Первая объемная скорость переноса жидкости больше";
            else TbA.Text = "Вторая объемная скорость переноса жидкости больше";

            Tbv.Text = string.Empty;
            Tbt.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task21Page());
        }
    }
}
