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
                CurrentUser = Users.ToList()[0];
            }
            SetLearningWords();
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

        public static void SetLearningWords()
        {
            List<int> idWordsForLeraning=new List<int>();
            for (int i = 0; i < _currentUser.countWordsForLearning; i++)
            {
                var rnd = new Random();
                int k = rnd.Next(0, NDictionary.countOfWords - 1);
                for (int j = 0; j < idWordsForLeraning.Count(); i++)
                {
                    if (idWordsForLeraning.Count() != 0 && k == idWordsForLeraning[j])
                    {
                        k = rnd.Next(0, NDictionary.countOfWords - 1);
                    }
                }
                _currentUser.wordsForLearning.Add(NDictionary.Words[k]);
            }
        }

    }
}
