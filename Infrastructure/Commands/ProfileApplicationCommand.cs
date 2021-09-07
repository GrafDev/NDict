using System;
using System.Collections.Generic;
using System.Text;
using NDict.Infrastructure.Commands.Base;
using NDict.Views;
using NDict.Views.Windows;

namespace NDict.Infrastructure.Commands
{
    class ProfileApplicationCommand : Command
    {
        UsersWindow userWindow = new UsersWindow();
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            App.TestVM.ShowTestWindow("1");
            if (!FlagLoadedDB)
            {
                FillInterface();
            }                       
=======
=======
            FillInterface();
>>>>>>> parent of fbd4757 ())
            userWindow = new UsersWindow();
>>>>>>> parent of f16510c () Загружена DB в список пользователей.)
            userWindow.Owner= NDict.App.Current.MainWindow;
            userWindow.Activate();
            userWindow.Show();            
            App.Current.MainWindow.IsEnabled = false;
        }
<<<<<<< HEAD

        public void FillInterface()
        {
            foreach (User user in Players.Users)
            {
<<<<<<< HEAD
                App.TestVM.ShowTestWindow("");
               // App.UsersVM.Select_User = App.MainVM.Button_Profile;
                App.UsersVM.ListOfUsers.Add(user.Name);
=======
                App.UsersVM.ListBox_ListOfUsers.Add(user.Name);
>>>>>>> parent of fbd4757 ())
            }
            FlagLoadedDB = true;
        }
=======
>>>>>>> parent of f16510c () Загружена DB в список пользователей.)
    }
}
