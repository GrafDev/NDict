using System;
using System.Collections.Generic;
using System.Text;
using NDict.Infrastructure.Commands.Base;
using NDict.Infrastructure;
using System.Windows;
using NDict.Views.Windows;
using NDict.Models;
using NDict.Services;

namespace NDict.Infrastructure.Commands.ChoiseProfileCommand
{
    class OkProfileCommand : Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {

            Action();

        }
        public void Action()
        {
            Players.SetCurrentUser(App.UsersVM.Select_User);
            //Tests.GetLearningWord();
            App.MainVM.Text_Button_Profile = Players.CurrentUser.Name;
            App.MainVM.Text_Button_Profile_Dificult = Players.CurrentUser.Difficult.ToString();
            App.MainVM.Text_Button_Play = Players.CurrentUser.TypeGame == 1 ? "Play" : "Train";            
            DBUsers.UpdateUser(Players.CurrentUser);
            Knobs.Loaded();

            foreach (Window _window in App.Current.Windows)
            {
                if (_window is UsersWindow)
                {
                    _window.Close();
                    NDict.App.Current.MainWindow.IsEnabled = true;
                    NDict.App.Current.MainWindow.Activate();
                }
            }



        }

    }
}
