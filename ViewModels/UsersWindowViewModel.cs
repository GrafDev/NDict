using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using NDict.Infrastructure.Commands;
using NDict.Models;
using System.Windows;
using NDict.Services;
using System.Linq;

namespace NDict.ViewModels
{
    public class UsersWindowViewModel : BaseViewModel
    {

        #region Text of Button of User

        private string _Button_Ok = "Ok";
        public string Text_Button_Ok { get => _Button_Ok; set => Set(ref _Button_Ok, value); }

        private string _Button_Add = "Add";
        public string Text_Button_Add { get => _Button_Add; set => Set(ref _Button_Add, value); }

        private string _Button_Delete = "Delete";
        public string Text_Button_Delete { get => _Button_Delete; set => Set(ref _Button_Delete, value); }

        private string _Select_User = Players.Current.Name;
        public string Text_Select_User { get => _Select_User; set => Set(ref _Select_User, value); }

        #endregion


        public UsersWindowViewModel()
        {
        }

    }
}
