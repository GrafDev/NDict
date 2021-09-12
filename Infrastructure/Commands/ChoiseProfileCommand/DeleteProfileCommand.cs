using System;
using System.Collections.Generic;
using System.Text;
using NDict.Infrastructure.Commands.Base;
using NDict.Infrastructure;
using System.Windows;
using NDict.Models;

namespace NDict.Infrastructure.Commands.ChoiseProfileCommand
{
    class DeleteProfileCommand:Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            var user = Players.Current;
            DB.DeleteUser(user);
        }

    }
}
