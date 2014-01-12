using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CA3.Models
{
    public class DbContextClass : DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<Supplier> supplier { get; set; }
    }
}