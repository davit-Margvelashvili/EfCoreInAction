using System;
using System.Collections.Generic;
using System.Text;
using EfCoreInAction.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCoreInAction.Data
{
    public class LibraryContext : DbContext
    {
        private const string ConnectionString =
            @"Server = (localdb)\MSSQLLocalDb; Database = LibraryDb; Trusted_Connection = true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Book> Books { get; set; }
    }
}