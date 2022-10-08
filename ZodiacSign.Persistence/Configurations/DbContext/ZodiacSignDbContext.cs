using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZodiacSign.Domain.Entities;
using ZodiacSign.Persistence.Configurations.DataConfigurations;

namespace ZodiacSign.Persistence.Configurations.DbContext
{
    public class ZodiacSignDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Element>? Elements { get; set; }
        public DbSet<Gem>? Gems { get; set; }
        public DbSet<Home>? Homes { get; set; }
        public DbSet<Sign>? Signs { get; set; }

        public ZodiacSignDbContext(DbContextOptions<ZodiacSignDbContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ElementConfiguration());
            modelBuilder.ApplyConfiguration(new GemConfiguration());
            modelBuilder.ApplyConfiguration(new HomeConfiguration());
            modelBuilder.ApplyConfiguration(new SignConfiguration());
        }
    }
}
