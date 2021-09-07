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
<<<<<<< HEAD
            //Players.Current.Name = App.UsersVM.Text_Select_User;
            App.MainVM.Button_Profile = App.UsersVM.Select_User;
            //App.MainVM.Text_Button_Profile = App.UsersVM.Text_Select_User;
=======
>>>>>>> parent of fbd4757 ())
            foreach (Window window in App.Current.Windows)
            {
                if (window is UsersWindow)
                {
<<<<<<< HEAD
                    window.Hide();
                    App.Current.MainWindow.IsEnabled = true;
                }               
=======
                    window.Close();
                    NDict.App.Current.MainWindow.IsEnabled = true;
                }
>>>>>>> parent of fbd4757 ())
                    
                //ЗАписать все изменения в базу данных юзеров
            }
        }
    }
}
