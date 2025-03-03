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
    /// Логика взаимодействия для Task26Page.xaml
    /// </summary>
    public partial class Task26Page : Page
    {
        public Task26Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double m_v, r_v, m_s, r_s;

            m_v = 4.86 * Math.Pow(10, 27);
            r_v = 6175 * 1000;
            m_s = 5.68 * Math.Pow(10, 29);
            r_s = 57750 * 1000;

            Task26 task26 = new Task26(m_v, r_v, m_s, r_s);

            if (task26.More()) TbA.Text = "Сатурн имеет наибольшее ускорение силы тяжести";
            else TbA.Text = "Венера имеет наибольшее ускорение силы тяжести";
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task27Page());
        }
    }
}
