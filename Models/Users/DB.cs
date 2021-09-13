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

    static class DB
    {
        static private ApplicationContext db;

        public static void Loaded()
        {
            LoadDB();
            Players.Loaded();
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

        public static void UpdateUser(User user)
        {
            db.Database.EnsureCreated();
            db.Users.Update(user);

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
