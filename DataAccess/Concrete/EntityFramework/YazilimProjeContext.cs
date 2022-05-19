using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public  class YazilimProjeContext :DbContext
    {
        //context=veri tabanı ile kendi klaslarımızı ilişkilendirdiğimiz yapı
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=PhoneBook;Trusted_Connection=true");

             //optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=PhoneBook;Trusted_Connection=True");

                

        }
        public DbSet<Customer> Customers { get; set; }
    }
}

