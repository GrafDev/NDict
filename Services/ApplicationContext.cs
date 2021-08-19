using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data.Entity;
using NDict.Models;

namespace NDict.Services
{
    class ApplicationContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext():base("DefaultConnection") { }
    }
}
