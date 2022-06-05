using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kitaphane.Areas.Identity.Data;
using Kitaphane.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Kitaphane.Data
{
    public class KitaphaneContext : IdentityDbContext<KitaphaneUser>
    {
        public KitaphaneContext(DbContextOptions<KitaphaneContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Author> Author { get; set; }

        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<OrderBook> OrderBook{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Kitaphane;Trusted_Connection=True;MultipleActiveResultSets=true");
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<KitaphaneUser>().ToTable("KitaphaneUser");

            builder.Entity<OrderBook>()
                 .HasKey(ob => new { ob.BookID, ob.OrderID });
            builder.Entity<OrderBook>()
                .HasOne(ob => ob.Book)
                .WithMany(ob => ob.Orders)
                .HasForeignKey(ob => ob.BookID);
            builder.Entity<OrderBook>()
                .HasOne(ob => ob.Order)
                .WithMany(ob => ob.Books)
                .HasForeignKey(ob => ob.OrderID);
        }


       
    }
}
