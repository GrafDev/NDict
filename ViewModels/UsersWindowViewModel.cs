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

<<<<<<< HEAD
        private string button_Ok = "Ok";
        public string Button_Ok { get => button_Ok; set => Set(ref button_Ok, value); }

        private string button_Add = "Add";
        public string Button_Add { get => button_Add; set => Set(ref button_Add, value); }

        private string button_Delete = "Delete";
        public string Button_Delete { get => button_Delete; set => Set(ref button_Delete, value); }

        private string select_User="Default";
        public string Select_User { get => select_User; set => Set(ref select_User, value); }

<<<<<<< HEAD
        private List<string> listOfUsers=new List<string>();
        internal List<string> ListOfUsers { get => listOfUsers; set => Set(ref listOfUsers, value); }
=======
        private string _Button_Ok = "Ok";
        public string Text_Button_Ok { get => _Button_Ok; set => Set(ref _Button_Ok, value); }

        private string _Button_Add = "Add";
        public string Text_Button_Add { get => _Button_Add; set => Set(ref _Button_Add, value); }

        private string _Button_Delete = "Delete";
        public string Text_Button_Delete { get => _Button_Delete; set => Set(ref _Button_Delete, value); }

        private string _Select_User = Players.Current.Name;
        public string Text_Select_User { get => _Select_User; set => Set(ref _Select_User, value); }

        private List<string> _ListOfUsers;
        public List<string> ListBox_ListOfUsers { get => _ListOfUsers; set => Set(ref _ListOfUsers, value); }
>>>>>>> parent of fbd4757 ())

        //private List<User> listOfUsers = new List<User>();
        //internal List<User> ListOfUsers { get => listOfUsers; set => Set(ref listOfUsers, value); }

=======
>>>>>>> parent of f16510c () Загружена DB в список пользователей.)
        #endregion


        public UsersWindowViewModel()
        {
<<<<<<< HEAD
<<<<<<< HEAD
            ListOfUsers.Add("asda");
            ListOfUsers.Add("asda11");
            ListOfUsers.Add("asdaaa");
            ListOfUsers.Add("asddasdfa");
            //var tempNames = from name in Players.Users
            //                select name.Name;
            //ListOfUsers = tempNames.ToList();
        }


=======
        }

>>>>>>> parent of f16510c () Загружена DB в список пользователей.)
=======
            ListBox_ListOfUsers = new List<string>();
        }
>>>>>>> parent of fbd4757 ())
    }
}
