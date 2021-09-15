using System;
using System.Collections.Generic;
using System.Text;
using NDict.Infrastructure.Commands.Base;
using NDict.Infrastructure;
using System.Windows;
using NDict.Models;

namespace NDict.Infrastructure.Commands.MainWindowCommand
{
    internal class CloseApplicationCommand : Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            if (App.MainVM.FlagButtonClose)
            {
                Application.Current.Shutdown();
            }
            else
            {
                Timers.ShowTime();
                Timers.Stop();
                
            }

        }

    }
}
