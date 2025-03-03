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
    /// Логика взаимодействия для Task25Page.xaml
    /// </summary>
    public partial class Task25Page : Page
    {
        public Task25Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double u1, r1, u2, r2;

            u1 = Convert.ToDouble(Tbu1.Text);
            r1 = Convert.ToDouble(Tbr1.Text);
            u2 = Convert.ToDouble(Tbu2.Text);
            r2 = Convert.ToDouble(Tbr2.Text);

            Task25 task25 = new Task25(u1, r1, u2, r2);

            if (task25.More()) TbA.Text = "По второму учатку протекает меньший ток";
            else TbA.Text = "По первому учатку протекает меньше ток";

            Tbu1.Text = string.Empty;
            Tbr1.Text = string.Empty;
            Tbu2.Text = string.Empty;
            Tbr2.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task26Page());
        }
    }
}
