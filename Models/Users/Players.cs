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
            _current = new User("Graf");
               
        }

    }
}
