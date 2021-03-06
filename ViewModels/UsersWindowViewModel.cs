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

        private string text_Button_Ok = "Ok";
        public string Text_Button_Ok { get => text_Button_Ok; set => Set(ref text_Button_Ok, value); }

        private string text_Button_Add = "Add";
        public string Text_Button_Add { get => text_Button_Add; set => Set(ref text_Button_Add, value); }

        private string text_Button_Delete = "Delete";
        public string Text_Button_Delete { get => text_Button_Delete; set => Set(ref text_Button_Delete, value); }

        private string select_User="Default";
        public string Select_User { get => select_User; set => Set(ref select_User, value); }

        private int difficult_User = 1;
        public int Difficult_User { get => difficult_User; set => Set(ref difficult_User, value); }

        private List<string> listOfUsers=new List<string>();
        public List<string> ListOfUsers { get => listOfUsers; set => Set(ref listOfUsers, value); }

        #endregion


        public UsersWindowViewModel()
        {

        }


    }
}
