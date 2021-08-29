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
using NDict.ViewModels;
using NDict.Models;
using NDict.Services;
using NDict.Views.Windows;

namespace NDict
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Test();
            //Dictionary.Loaded();
            //Knobs.Loaded();
            InitializeComponent();

        }

        private void titleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        void Test()
        {
            TestWindow testWindow;
            Dictionary.Loaded();            
            //Knobs.Loaded();
            testWindow = new TestWindow();
            testWindow.Show();
            testWindow.Activate();
            var testViewModel = new TestViewModel();
            //TODO: неободимо решить как связать тестовое поле с другими данными (service)
            //testViewModel.TestBlock = Dictionary.Words.Count.ToString();

        }

    }
}
