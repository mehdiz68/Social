using System;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>().HasData(

                new Value() { Id = 1, Name = "a1" },
                new Value() { Id = 2, Name = "a2" },
                new Value() { Id = 3, Name = "a3" }
            );
        }
        public DbSet<Value> Values { get; set; }


    }
}
