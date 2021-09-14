using System;
using System.Collections.Generic;
using System.Text;
using NDict.Infrastructure.Commands.Base;
using NDict.Infrastructure;
using System.Windows;
using NDict.Models;
using System.Linq;

namespace NDict.Infrastructure.Commands.ChoiseProfileCommand
{
    class DeleteProfileCommand:Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            var user = App.UsersVM.Select_User;
            DBUsers.DeleteUser(user);
            Players.DeleteUser(user);
            App.UsersVM.ListOfUsers.Remove(user);
            App.UsersVM.Select_User = Players.Users.ToList()[0];
        }

    }
}
