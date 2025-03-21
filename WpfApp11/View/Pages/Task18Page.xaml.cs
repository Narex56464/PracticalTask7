﻿using System;
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
    /// Логика взаимодействия для Task18Page.xaml
    /// </summary>
    public partial class Task18Page : Page
    {
        public Task18Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c;

            a = Convert.ToDouble(Tba.Text);
            b = Convert.ToDouble(Tbb.Text);
            c = Convert.ToDouble(Tbc.Text);

            Task18 task18 = new Task18(a, b, c);

            if (task18.Exp()) TbA.Text = "Труегольник является равнобедренным";
            else TbA.Text = "Треугольние не является равнобедренным";

            Tba.Text = string.Empty;
            Tbb.Text = string.Empty;
            Tbc.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task19Page());
        }
    }
}
