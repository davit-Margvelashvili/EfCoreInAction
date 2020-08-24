using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EfCoreInAction.Core;
using EfCoreInAction.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCoreInAction.Data
{
    public class Repository : IRepository
    {
        public List<Book> ListAll()
        {
            using (var db = new LibraryContext())
            {
                return db.Books.AsNoTracking().Include(b => b.Author).ToList();
            }
        }
    }
}