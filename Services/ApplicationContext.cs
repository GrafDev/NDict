using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using NDict.Models;

namespace NDict.Services
{
    class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public string DbPath { get; private set; }

        public ApplicationContext()
        {
            //var folder = Environment.SpecialFolder.LocalApplicationData;
            //var path = Environment.GetFolderPath(folder);
            //DbPath = "DB_NDictUsers.db";
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source=DB_NDictUsers.db");
    }
}
