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
using NDict.Services;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows.Data;

namespace NDict
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

       public static MainWindowViewModel MainVM { get; }
        public static UsersWindowViewModel UsersVM { get; }
        public static TestViewModel TestVM { get;  }
        public static AddUserViewModel AddUserVM { get; }

        static App()
        {
            TestVM = new TestViewModel();

            DBUsers.Loaded();
            NDictionary.Loaded();            
            Knobs.Loaded();

            MainVM = new MainWindowViewModel();
            UsersVM = new UsersWindowViewModel();            
            AddUserVM = new AddUserViewModel();
            
        }


    }
}
