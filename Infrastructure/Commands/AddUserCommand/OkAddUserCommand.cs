using System;
using System.Collections.Generic;
using System.Text;
using NDict.Infrastructure.Commands.Base;
using NDict.Infrastructure;
using System.Windows;
using NDict.Views.Windows;
using NDict.Models;

namespace NDict.Infrastructure.Commands.AddUserCommand
{
    class OkAddUserCommand: Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
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

            User user = new User { Name = App.AddUserVM.UserName};
            DB.AddUser(user);
            App.UsersVM.ListOfUsers.Add(user.Name);
            Players.Users.Add(user);
            //ЗАписать все изменения в базу данных юзеров

        }
    }
}
