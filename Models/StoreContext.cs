using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework_52.Models
{
    public class StoreContext : DbContext

    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brend> Brends { get; set; }
        public DbSet<Order> Orders { get; set; }

        public StoreContext(DbContextOptions<StoreContext> options)

            : base(options)

        {

        }

    }
}
