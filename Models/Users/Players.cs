using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
<<<<<<< HEAD
using NDict.Models.Users;
using NDict.ViewModels;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
=======
>>>>>>> parent of f16510c () Загружена DB в список пользователей.)

namespace NDict.Models
{
    public static class Players
    {
        static User _current;
<<<<<<< HEAD
        internal static User Current { get => _current; set => _current=value; }

        private static List<User> users = new List<User>();
        internal static List<User> Users { get => users; set => users = value; }

        public static void Loaded()
        {
            Users = DB.Users;
=======
        public static User Current { get => _current; set => _current = value; }
        
        private static ICollection<User> users;

        internal static ICollection<User> Users { get => users; set => users = value; }

        public static void Loaded()
        {
            _current = new User("Graf");
>>>>>>> parent of f16510c () Загружена DB в список пользователей.)
        }
           

    }


}
