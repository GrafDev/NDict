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
                DBUsers.UpdateUser(Players.CurrentUser);
                Application.Current.Shutdown();               

            }
            else
            {
                if (App.MainVM.flagPlayProcess)
                {
                    Timers.ShowTime();
                    Timers.Stop();
                    App.MainVM.Text_Button_Close = "Close";
                    App.MainVM.Text_Button_Play = Players.CurrentUser.TypeGame == 0 ? "Train" : "Play";
                    App.MainVM.FlagButtonClose = true;
                    App.MainVM.flagPlayProcess = false;
                    //App.MainVM.Border_CloseButton_Brash = "Black";
                    App.MainVM.Border_CloseButton_Thinkness = "0";                    
                    Knobs.ClearKnobs();
                }

            }

        }

    }
}
