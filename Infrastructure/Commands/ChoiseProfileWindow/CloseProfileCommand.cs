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
            App.MainVM.Text_Button_Profile = App.UsersVM.Text_Select_User;
            foreach (Window window in App.Current.Windows)
            {
                if (window is UsersWindow)
                {
                    window.Close();
                    App.Current.MainWindow.IsEnabled = true;
                }               
                    
                //ЗАписать все изменения в базу данных юзеров
            }
           
        }
    }
}
