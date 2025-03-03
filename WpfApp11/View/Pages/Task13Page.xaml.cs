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
    /// Логика взаимодействия для Task13Page.xaml
    /// </summary>
    public partial class Task13Page : Page
    {
        public Task13Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            double deposit, term;

            deposit = Convert.ToDouble(Tba.Text);
            term = Convert.ToDouble(Tbb.Text);

            Task13 task13 = new Task13(deposit, term);

            TbA.Text = task13.Payments();

            Tba.Text = string.Empty;
            Tbb.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task14Page());
        }
    }
}
