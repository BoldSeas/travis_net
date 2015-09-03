using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Shop.Models;

namespace Shop.DAL
{
    public class ShopContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}