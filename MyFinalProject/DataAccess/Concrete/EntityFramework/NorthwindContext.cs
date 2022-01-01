using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje classlarını bağlamak
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Ters slash(\) işaretinin tek başına bir anlam9ı olduğundan dolayı (@) işareti kullanıyoruz.
            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
            //Burada nereye bağlanacağımızı giriyoruz. localdb bilgisayarımdaki sql serverin adı.
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
