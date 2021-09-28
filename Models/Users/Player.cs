using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NDict.Models;
using NDict.Services;

namespace NDict.Models

{
    static class Player
    {
        static User _currentUser;
        static bool flagLanguage;
        public static User CurrentUser { get => _currentUser; set => _currentUser = value; }
        
        private static ICollection<User> users;
        internal static ICollection<User> Users { get => users; set => users = value; }
        public static bool FlagLanguage { get => flagLanguage; set => flagLanguage = value; }

        public static void Loaded()
        {
            CurrentUser = new User();
            bool FlagCurrentUser = false;
            Users = DBUsers.GetUsers();
            foreach(User _user in Users)
            {
                if (!FlagCurrentUser && _user.FlagCurrent > 0)
                {
                    CurrentUser = _user;
                    FlagCurrentUser = true;
                }                   
            }
            if (!FlagCurrentUser)
            {
                CurrentUser = Users.ToList()[0];// При удалении юзера, текуйщим юзером принимается верхний
            }
            
        }
        public static void SetCurrentUser(User _user)
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
        public static void DeleteUser(User _user)
        {
            Users.Remove(_user);
        }

        public static void AddUser(User _user)
        {
            Users.Add(_user);
        }

        public static void GetFlagLanguage()
        {
            var rnd = new Random();
            var _language = rnd.Next(0, 2);
            FlagLanguage = _language>0?true:false;            
        }
    }
}
