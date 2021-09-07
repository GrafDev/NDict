using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using NDict.ViewModels;
using NDict.Models;
using NDict.Views.Windows;
using NDict.Services;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows.Data;
using System.Collections.ObjectModel;
using System.Windows.Controls;



namespace NDict.Models.Users
{

    static class DB
    {
        static private ApplicationContext db;

        static internal List<User> Users;

        public static void Loaded()
        {
            LoadDB();
            User user = new User("Name3");
            AddUser(user);
        }
        public static void LoadDB()
        {
            db = new ApplicationContext();
<<<<<<< HEAD:Models/Users/DB.cs
            Users = db.Users.ToList();
            //Players.Users = db.Users.ToList();
            //App.TestVM.TestBlock = db.Users.Count().ToString();
            //App.TestVM.ShowTestWindow();
=======

            // App.TestVM.TestBlock = db.Users.ToList().ToString();

>>>>>>> parent of f16510c () Загружена DB в список пользователей.):Models/Users/UsersDB.cs
        }
        public static void AddUser(User user)
        {
            db.Database.EnsureCreated();
            db.Users.Add(user);
            db.SaveChanges();
        }
<<<<<<< HEAD:Models/Users/DB.cs
        public static void UpdateUser(User user)
        {
            var updateUsers =
                from tempUser in db.Users
                where tempUser.Id == user.Id
                select tempUser;

            foreach (var _user in updateUsers)
            {
                db.Users.Update(_user);
            }

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                App.TestVM.ShowTestWindow(e.ToString());
            }

        }
=======

>>>>>>> parent of f16510c () Загружена DB в список пользователей.):Models/Users/UsersDB.cs
        public static void DeleteUser(User user)
        {
            var deleteUser =
                from tempUser in db.Users
                where tempUser.Id == user.Id
                select tempUser;

            foreach (var _user in deleteUser)
            {
                db.Users.Remove(_user);
            }

            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                App.TestVM.ShowTestWindow(e.ToString());
            }
        }




    }

}
