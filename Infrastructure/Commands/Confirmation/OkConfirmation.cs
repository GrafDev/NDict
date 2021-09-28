using System;
using System.Collections.Generic;
using System.Text;
using NDict.Infrastructure.Commands.Base;
using NDict.Infrastructure;
using System.Windows;
using NDict.Views.Windows;
using NDict.Models;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using NDict.ViewModels;
using NDict.Views.Windows.Modal;
using NDict.Services;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows.Data;

namespace NDict.Infrastructure.Commands.Confirmation

{
    class OkConfirmation: Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            Action();
        }
        public bool Action()
        {

            foreach (Window window in App.Current.Windows)
            {
                if (window is ConfirmationWindow)
                {
                    window.IsEnabled = false;
                    window.Close();
                }

                if (window is UsersWindow)
                {
                    window.IsEnabled = true;
                }
            }
                var user = App.UsersVM.Select_User;
                DBUsers.DeleteUser(user);
                Player.DeleteUser(user);
                App.UsersVM.ListOfUsers.Remove(user);
                App.UsersVM.Select_User = Player.Users.ToList()[0];
            return true;
        }
    }
}
