using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using NDict.Infrastructure.Commands;
using NDict.Models;
using System.Windows;
using NDict.Services;
using System.Linq;
using NDict.Models.Users;

namespace NDict.ViewModels
{
    public class UsersWindowViewModel : BaseViewModel
    {

        #region Text of Button of User

        private string button_Ok = "Ok";
        public string Button_Ok { get => button_Ok; set => Set(ref button_Ok, value); }

        private string button_Add = "Add";
        public string Button_Add { get => button_Add; set => Set(ref button_Add, value); }

        private string button_Delete = "Delete";
        public string Button_Delete { get => button_Delete; set => Set(ref button_Delete, value); }

        private string select_User="Default";
        public string Select_User { get => select_User; set => Set(ref select_User, value); }

        private List<string> listOfUsers=new List<string>();
        internal List<string> ListOfUsers { get => listOfUsers; set => Set(ref listOfUsers, value); }

        //private List<User> listOfUsers = new List<User>();
        //internal List<User> ListOfUsers { get => listOfUsers; set => Set(ref listOfUsers, value); }

        #endregion


        public UsersWindowViewModel()
        {
            var tempNames = from name in Players.Users
                            select name.Name;
            ListOfUsers = tempNames.ToList();
        }


    }
}
