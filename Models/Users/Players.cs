using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NDict.Models;

namespace NDict.Models

{
    static class Players
    {
        static User _current;
        public static User Current { get => _current; set => _current = value; }
        
        private static ICollection<User> users;
        internal static ICollection<User> Users { get => users; set => users = value; }

        public static void Loaded()
        {
            Current = new User();
            bool FlagCurrent = false;
            Users = DB.GetUsers();
            foreach(User _user in Users)
            {
                if (!FlagCurrent && _user.Current > 0)
                {
                    Current = _user;
                    FlagCurrent = true;
                }                   
            }
            if (!FlagCurrent)
            {
                Current = Users.ToList()[0];
            }

        }
        public static void SetCurrent(User _user)
        {
            foreach(User user in Users)
            {
                user.Current = 0;
                DB.UpdateUser(user);
            }
            _user.Current = 1;
            DB.UpdateUser(_user);
        }

    }
}
