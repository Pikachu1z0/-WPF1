﻿using AAA.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AAA
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MyViewModel a = new  MyViewModel();
            MainWindow s = new MainWindow();
            s.DataContext = a;
            s.ShowDialog();
        }
    }
}
