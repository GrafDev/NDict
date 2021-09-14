using System;
using System.Collections.Generic;
using System.Text;
using NDict.Infrastructure.Commands.Base;
using NDict.Infrastructure;
using System.Windows;
using NDict.Views.Windows;
using NDict.Models;

namespace NDict.Infrastructure.Commands.ChoiseProfileCommand
{
    class OkProfileCommand: Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {

            Action(true);

        }
        public void Action(bool FlagOkCancel)
        {
            if (FlagOkCancel)
            {
                Players.CurrentUser = App.UsersVM.Select_User;
                App.MainVM.Text_Button_Profile = Players.CurrentUser.Name;
                Players.SetCurrentUser(Players.CurrentUser);
                DBUsers.UpdateUser(Players.CurrentUser);
            }

            foreach (Window _window in App.Current.Windows)
            {
                if (_window is UsersWindow)
                {
                    _window.Close();
                    NDict.App.Current.MainWindow.IsEnabled = true;
                    NDict.App.Current.MainWindow.Activate();
                }
            }
        }
        
    }
}
