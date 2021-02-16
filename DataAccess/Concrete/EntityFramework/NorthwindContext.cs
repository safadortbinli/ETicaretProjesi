using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: nesnei db tabloları ile proje classlarını bağlamak
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; } //Hangi Db deki tablo bizim hangi tablomuza denk geliyor onu yazılyoruz.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public  DbSet<Order> Orders { get; set; }


    }
}
