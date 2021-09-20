using System;
using System.Collections.Generic;
using System.Text;
using NDict.Infrastructure.Commands.Base;
using NDict.Views;
using NDict.Views.Windows;
using NDict.Models;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using NDict.ViewModels;
using NDict.Services;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows.Data;

namespace NDict.Infrastructure.Commands.MainWindowCommand
{
    class ProfileApplicationCommand : Command
    {
        UsersWindow userWindow;
        public override bool CanExecute(object parameter) => true;

        private bool FlagLoadedDB = false;
        public override void Execute(object parameter)
        {
            if (!FlagLoadedDB)
            {
                FillInterface();
                    }
            userWindow = new UsersWindow();
            userWindow.Owner= NDict.App.Current.MainWindow;
            userWindow.Show();
            userWindow.Activate();
            App.UsersVM.ListOfUsers = Players.Users.ToList();
            App.UsersVM.Select_User = Players.CurrentUser;
            App.UsersVM.current_User = Players.CurrentUser;
            App.UsersVM.current_BaseOfUsers = Players.Users.ToList();
            App.Current.MainWindow.IsEnabled = false;

        }
            
        public void FillInterface()
        {
            FlagLoadedDB = true;
        }
    }
}
