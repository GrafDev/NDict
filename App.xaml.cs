using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using NDict.ViewModels;
using NDict.Models;
using NDict.Views.Windows;

namespace NDict
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        App()
        {
            Test();
            
        }
        void Test()
        {
            TestWindow testWindow;
            Dictionary.Loaded();
            ////Knobs.Loaded();
            testWindow = new TestWindow();
            testWindow.Show();
            testWindow.Activate();
            testWindow.Content = Dictionary.Words.ToString();
            ////TODO: неободимо решить как связать тестовое поле с другими данными (service)
            ////testViewModel.TestBlock = Dictionary.Words.Count.ToString();

        }
    }
}
