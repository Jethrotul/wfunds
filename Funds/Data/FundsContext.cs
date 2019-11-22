using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Funds.Data
{
    public class FundsContext : DbContext
    {
        public FundsContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Fund> Funds { get; set; }
        public DbSet<FundType> FundTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fund>()
                .HasKey(f => f.FundId);

            modelBuilder.Entity<FundType>()
               .HasKey(f => f.Name);

            modelBuilder.Entity<Fund>()
                .HasOne(f => f.FundType)
                .WithMany(f => f.Funds)
                .HasForeignKey(f => f.FundTypeName);

           modelBuilder.Entity<FundType>()
                .HasData(
                    new FundType { Name = "Active" },
                    new FundType { Name = "Passive" },
                    new FundType { Name = "Hybrid" }
                );

            modelBuilder.Entity<Fund>()
                .HasData(
                    new Fund { 
                        FundId = 1, 
                        Isin = "ES0180792006", 
                        Name = "True value FI", 
                        Price = 16.31, 
                        AReturn = 14.18, 
                        A5Return = 11.74, 
                        Manager = "Renta 4 Gestora" , 
                        Category = "Renta variable", 
                    }
                );
        }
    }
}
