using System;
using System.Collections.Generic;
using System.Text;
using NDict.Infrastructure.Commands.Base;
using NDict.Infrastructure;
using System.Windows;
using NDict.Models;
using NDict.Infrastructure.Commands;
using NDict.Views;
using NDict.Views.Windows;


namespace NDict.Infrastructure.Commands.ChoiseProfileCommand
{
    class AddProfileCommand : Command
    {
        AddUserWindow addUserWindow;
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {

            foreach (Window window in App.Current.Windows)
            {
                if (window is UsersWindow)
                {                    
                    addUserWindow = new AddUserWindow();
                    addUserWindow.Owner = window;
                    addUserWindow.Show();
                    addUserWindow.Activate();
                    window.IsEnabled = false;
                }

            }

        }
    }
}
