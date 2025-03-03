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
    /// Логика взаимодействия для Task24Page.xaml
    /// </summary>
    public partial class Task24Page : Page
    {
        public Task24Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double sk, sc;

            sk = Convert.ToDouble(Tbsk.Text);
            sc = Convert.ToDouble(Tbsc.Text);

            Task24 task24 = new Task24(sk, sc);

            TbA.Text = $"{task24.ExpA()}{task24.ExpB()}";

            Tbsk.Text = string.Empty;
            Tbsc.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task25Page());
        }
    }
}
