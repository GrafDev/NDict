using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NDict.Models.Users;
using NDict.ViewModels;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NDict.Models
{
    public static class Players
    {
        static User _current;
        internal static User Current { get => _current; set => _current=value; }

        private static List<User> users = new List<User>();
        internal static List<User> Users { get => users; set => users = value; }

        public static void Loaded()
        {
            Users = DB.Users;
        }
           

    }


}
