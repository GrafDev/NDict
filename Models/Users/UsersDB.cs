﻿using System;
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
                //Console.WriteLine(e);
                // Provide for exceptions.
            }
        }




    }

}