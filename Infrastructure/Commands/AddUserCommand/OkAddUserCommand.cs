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
using NDict.Services;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows.Data;

namespace NDict.Infrastructure.Commands.AddUserCommand
{
    class OkAddUserCommand : Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            Action();
        }
        public void Action()
        {
            string _name = App.AddUserVM.UserName.TrimEnd().TrimStart();

            if (_name.Length > 3 && _name != "Default")
            {
                User user = new User { Name = _name };
                DBUsers.AddUser(user);
                Players.AddUser(user);
                Players.SetCurrentUser(user);
                App.UsersVM.ListOfUsers = Players.Users.ToList();
                App.UsersVM.Select_User = user; // TODO: Current name                
                CheckDefaultName();

                foreach (Window window in App.Current.Windows)
                {
                    if (window is AddUserWindow)
                    {
                        window.IsEnabled = false;
                        window.Close();
                    }
                }
                foreach (Window window in App.Current.Windows)
                {
                    if (window is UsersWindow)
                    {
                        window.IsEnabled = true;
                    }
                }
                App.AddUserVM.UserName = "";
            }

        }

        private void CheckDefaultName()
        {
            User _user = new User();
            bool FlagDefaultUser = false;
            foreach (User user in Players.Users)
            {
                if (user.Name == "Default")
                {
                    _user = user;
                    FlagDefaultUser = true;
                    continue;
                }
            }
            if (FlagDefaultUser)
            {
                DBUsers.DeleteUser(_user);
                Players.DeleteUser(_user);
            }
        }
    }
}
