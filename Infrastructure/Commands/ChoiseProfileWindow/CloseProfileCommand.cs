using System;
using System.Collections.Generic;
using System.Text;
using NDict.Infrastructure.Commands.Base;
using NDict.Infrastructure;
using System.Windows;
using NDict.Views.Windows;
using NDict.Models;

namespace NDict.Infrastructure.Commands.ChoiseProfileWindow
{
    class CloseProfileCommand: Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            foreach (Window window in App.Current.Windows)
            {
                if (window is UsersWindow)
                {
                    window.Hide();
                   // App.MainVM.Text_Button_Profile = App.UsersVM.Select_User;                    
                    NDict.App.Current.MainWindow.IsEnabled = true;
                    SetPlayer(App.UsersVM.Select_User);
                    App.MainVM.Text_Button_Profile = Players.Current.Name;
                }
                                    
                //ЗАписать все изменения в базу данных юзеров
            }
           
        }

        void SetPlayer(String _name)
        {
            foreach(User user in Players.Users)
            {
                if (user.Name.Equals(_name))
                {
                    Players.Current = user;
                }
            }
        }
    }
}
