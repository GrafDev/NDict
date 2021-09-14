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

        private User select_User;
        public User Select_User { get => select_User; set => Set(ref select_User, value);}

        private List<User> listOfUsers = new List<User>();
        public List<User> ListOfUsers { get => listOfUsers; set => Set(ref listOfUsers, value); }

        #endregion


        public UsersWindowViewModel()
        {
            
        }


    }
}
