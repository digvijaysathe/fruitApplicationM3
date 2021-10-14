using fruitApplicationM3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fruitApplicationM3.Repository
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Fruit> Fruits { get; set; }
    }
}
