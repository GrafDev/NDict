using System;
using System.Collections.Generic;
using System.Text;
using NDict.Infrastructure.Commands.Base;
using NDict.Infrastructure;
using System.Windows;
using NDict.Views.Windows;
using NDict.Models;
using NDict.Models.Users;

namespace NDict.Infrastructure.Commands.ChoiseProfileWindow
{
    class CloseProfileCommand: Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter)
        {
            //Players.Current.Name = App.UsersVM.Text_Select_User;
            App.MainVM.Button_Profile = App.UsersVM.Select_User;
            //App.MainVM.Text_Button_Profile = App.UsersVM.Text_Select_User;
            foreach (Window window in App.Current.Windows)
            {
                if (window is UsersWindow)
                {
                    window.Hide();
                    App.Current.MainWindow.IsEnabled = true;
                }               
                    
                //ЗАписать все изменения в базу данных юзеров
            }
           
        }
    }
}
