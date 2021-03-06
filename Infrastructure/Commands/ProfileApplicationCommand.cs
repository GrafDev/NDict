using System;
using System.Collections.Generic;
using System.Text;
using NDict.Infrastructure.Commands.Base;
using NDict.Views;
using NDict.Views.Windows;
using NDict.Models;

namespace NDict.Infrastructure.Commands
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
            App.Current.MainWindow.IsEnabled = false;
        }

        public void FillInterface()
        {
            foreach (User user in Players.Users)
            {
                App.UsersVM.ListOfUsers.Add(user.Name);
                FlagLoadedDB = true;
            }
        }
    }
}
