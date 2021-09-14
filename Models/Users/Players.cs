using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NDict.Models;

namespace NDict.Models

{
    static class Players
    {
        static User _currentUser;
        public static User CurrentUser { get => _currentUser; set => _currentUser = value; }
        
        private static ICollection<User> users;
        internal static ICollection<User> Users { get => users; set => users = value; }

        public static void Loaded()
        {
            CurrentUser = new User();
            bool FlagCurrent = false;
            Users = DBUsers.GetUsers();
            foreach(User _user in Users)
            {
                if (!FlagCurrent && _user.FlagCurrent > 0)
                {
                    CurrentUser = _user;
                    FlagCurrent = true;
                }                   
            }
            if (!FlagCurrent)
            {
                CurrentUser = Users.ToList()[0];
            }

        }
        public static void SetCurrent(User _user)
        {
            
            foreach(User user in Users)
            {
                user.FlagCurrent = 0;
                DBUsers.UpdateUser(user);
            }
            _user.FlagCurrent = 1;
            _currentUser = _user;
            DBUsers.UpdateUser(_user);
        }

    }
}
