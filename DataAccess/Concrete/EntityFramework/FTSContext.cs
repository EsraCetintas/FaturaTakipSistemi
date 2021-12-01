using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
   public class FTSContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-0UJ73TU4\SQLEXPRESS;Initial Catalog=FTS;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-0UJ73TU4\SQLEXPRESS;Database=FTS;Trusted_Connection=true");
        }

        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Debt> Debts { get; set; }
        public DbSet<Due> Dues { get; set; }
        public DbSet<Flat> Flats { get; set; }
        public DbSet<FlatType> FlatTypes { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Payment> Payments { get; set; }

    }
}
