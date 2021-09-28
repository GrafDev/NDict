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



namespace NDict.Models
{

    static class DBUsers
    {
        static private ApplicationContext db;

        public static void Loaded()
        {
            LoadDB();            
        }

        public static void LoadDB()
        {
            db = new ApplicationContext();
            if (db.Users.Count() < 1)
            {
                var _user = new User();
                _user.Name = "Default";
                _user.Difficult = 1;
                db.Database.EnsureCreated();
                db.Users.Add(_user);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e);
                    // Provide for exceptions.
                }
            }

            // App.TestVM.TestBlock = db.Users.ToList().ToString();
        }
        public static void AddUser(User _user)
        {
            db.Database.EnsureCreated();
            _user.Difficult = 1;
            db.Users.Add(_user);
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                // Provide for exceptions.
            }
            App.UsersVM.ListOfUsers = GetUsers();
        }

        public static void UpdateUser(User _user)
        {
            db.Database.EnsureCreated();
            db.Users.Update(_user);

            try
            {   
                db.SaveChanges();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                // Provide for exceptions.
            }
            App.UsersVM.ListOfUsers = GetUsers();
        }
        public static void DeleteUser(User user)
        {
            db.Database.EnsureCreated();
            db.Users.Remove(user);


            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                // Provide for exceptions.
            }
            App.UsersVM.ListOfUsers = GetUsers();

        }
        public static List<User> GetUsers()
        {
            var _users = db.Users.ToList();
            return _users;
        }
    }
}
