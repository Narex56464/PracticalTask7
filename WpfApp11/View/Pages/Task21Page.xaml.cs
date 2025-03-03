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
    /// Логика взаимодействия для Task21Page.xaml
    /// </summary>
    public partial class Task21Page : Page
    {
        public Task21Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double sk, sc, r;

            sk = Convert.ToDouble(Tbsk.Text);
            sc = Convert.ToDouble(Tbsc.Text);
            r = Convert.ToDouble(Tbr.Text);

            Task21 task21 = new Task21(sk, sc, r);

            TbA.Text = $"{task21.AnsA()}{task21.AnsB()}";

            Tbsc.Text = string.Empty;
            Tbr.Text = string.Empty;
            Tbsk.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task22Page());
        }
    }
}
