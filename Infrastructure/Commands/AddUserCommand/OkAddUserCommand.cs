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
            string _name = App.AddUserVM.UserName;
            if (_name.Length <= 3)
            {
                foreach (Window _window in App.Current.Windows)
                {
                    if (_window is AddUserWindow)
                    {
                        object obj = _window.FindName("NewUserName"); 
                        System.Windows.Controls.TextBox pop = (System.Windows.Controls.TextBox)obj;
                        pop.ToolTip = "Введите имя длиннее трех символов";

                    }

                }
            }
            else
            {
                User user = new User { Name = _name };
                DB.AddUser(user);
                Players.Users.Add(user);
                App.UsersVM.ListOfUsers = Players.Users.ToList();

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
