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
    class OkAddUserCommand: Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            string _name = App.AddUserVM.UserName.TrimEnd().TrimStart();
            if (_name.Length > 3)
            {
                User user = new User { Name = _name };
                DB.AddUser(user);                
                Players.Users.Add(user);
                Players.Current = user; //TODO: Current name
                Players.SetCurrent(Players.Current);
                App.UsersVM.ListOfUsers = Players.Users.ToList();
                App.UsersVM.Select_User = user; // TODO: Current name
                foreach (Window window in App.Current.Windows)
                {

                    if (window is AddUserWindow)
                    {
                        window.Close();
                    }

                    if (window is UsersWindow)
                    {
                        window.IsEnabled = true;
                    }

                }
                App.AddUserVM.UserName = "";
            }
        }
    }
}
