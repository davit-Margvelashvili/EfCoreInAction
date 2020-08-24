using System;
using System.Collections.Generic;
using System.Text;
using EfCoreInAction.Core.Models;

namespace EfCoreInAction.Core
{
    public interface IRepository
    {
        List<Book> ListAll();
    }
}