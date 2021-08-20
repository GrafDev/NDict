using System;
using System.Collections.Generic;
using System.Text;
using NDict.Infrastructure.Commands.Base;
using NDict.Infrastructure;
using System.Windows;

namespace NDict.Infrastructure.Commands
{
    class CloseProfileCommand: Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            Window _window;
            if (parameter is Window)
            {
                _window= (Window)parameter;
                _window.Close();                
            }

        }
    }
}
