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

namespace WpfApp11.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task27Page.xaml
    /// </summary>
    public partial class Task27Page : Page
    {
        public Task27Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double hours, minutes;

            hours = Convert.ToDouble(Tbh.Text);
            minutes = Convert.ToDouble(Tbm.Text);

            if (hours >= 0 && hours <= 12) TbA.Text = $"Time: {hours}:{minutes} am";
            else if (hours >= 12 && hours <= 24) TbA.Text = $"Time: {hours}:{minutes} pm";
            else TbA.Text = "Не правильно указано время";

            Tbh.Text = string.Empty;
            Tbm.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task28Page());
        }
    }
}
