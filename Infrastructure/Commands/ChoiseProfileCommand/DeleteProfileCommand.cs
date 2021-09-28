using System;
using System.Collections.Generic;
using System.Text;
using NDict.Infrastructure.Commands.Base;
using NDict.Infrastructure;
using System.Windows;
using NDict.Models;
using System.Linq;
using NDict.Views.Windows.Modal;
using NDict.Views.Windows;

namespace NDict.Infrastructure.Commands.ChoiseProfileCommand
{
    class DeleteProfileCommand : Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            

            if (Player.Users.Count > 1)
            {

                var okOrCancelWindow = new ConfirmationWindow();
                foreach (Window window in App.Current.Windows)
                {

                    if (window is UsersWindow)
                    {
                        okOrCancelWindow.Owner = window;
                        okOrCancelWindow.Show();
                        okOrCancelWindow.Activate();
                        window.IsEnabled = false;
                        continue;

                    }
                }


            }

        }

    }
}
