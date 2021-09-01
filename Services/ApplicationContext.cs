using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using NDict.Models;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Sqlite;


namespace NDict.Services
{
    class ApplicationContext : DbContext
    {

        public DbSet<User> Users { get; set; }
     
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=DB_NDictUsers.db", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }
    }
}


