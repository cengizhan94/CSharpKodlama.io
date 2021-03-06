using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkDemo
{
    //Sql ve ilişkisel veri tabanı tasarımını öğren.
    //DbContext Microsoft.EntityFrameworkCore'u Nuget kullanarak kurdum. Kurduğum bu paketin son sürümü 6.0.1'di. 
    //Son sürümü kurulum sırasında hata verdiğinden 3.9.1 'i yani Engin hocanın kurduğu sürümü kurdum. Hatasız kuruldu.
    //kendi sistemimde .Net Core 3.1 kurulu olduğu için bu hatayı aldığımı öğrendim.
    public class NorthwindContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //@ işareti, ters slash(\) işaretinin tek başına anlamı olduğundan dolayı kullanıldı.
            //Alttaki kod ile hangi veritabanına bağlanılacağını belirtiyoruz.
            optionsBuilder.UseSqlServer(@"Server = (localdb)\projectsv13;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; } // Veritabanındaki Products ile kullandığımız Product class'ını ilişkilendiriyoruz.
    }


  
}
