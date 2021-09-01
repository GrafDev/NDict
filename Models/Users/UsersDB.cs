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
using System.Data.Linq;



namespace NDict.Models.Users
{

    static class UsersDB
    {
        static private ApplicationContext db;

        public static void Loaded()
        {
            LoadDB();
            User user = new User("Name3");
            AddUser(user);
        }
        public static void LoadDB()
        {
            db = new ApplicationContext();

            // App.TestVM.TestBlock = db.Users.ToList().ToString();

        }
        public static void AddUser(User user)
        {
            db.Database.EnsureCreated();
            db.Users.Add(user);
            db.SaveChanges();
        }

        public static void DeleteUser(User _user)
        {
            db.Database.EnsureCreated();
            db.Users.Add(_user);
            db.SaveChanges();

            var deleteUser =
                from user in db.Users
                where user.Id == _user.Id
                select user;

            foreach (var user in deleteUser)
            {
                db.Users.DeleteOnSubmit(user);
            }

            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                // Provide for exceptions.
            }
        }




    }

}
