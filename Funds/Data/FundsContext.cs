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

            modelBuilder.Entity<Fund>()
                .HasOne(f => f.FundType)
                .WithMany(f => f.Funds)
                .HasForeignKey(f => f.FundTypeName);

            modelBuilder.Entity<FundType>()
                .HasKey(f => f.Name);


            modelBuilder.Entity<FundType>()
                .HasData(
                    new FundType { Name = "Activo" },
                    new FundType { Name = "Pasivo" },
                    new FundType { Name = "Híbrido" }
                );


            modelBuilder.Entity<Fund>()
                .HasData(
                    new Fund { FundId = 1, Name = "True value", Country = "España", FundTypeName = "Activo", Price = 850 },
                    new Fund { FundId = 2, Name = "Cobas", Country = "España", FundTypeName = "Activo", Price = 1020 },
                    new Fund { FundId = 3, Name = "Índice SP500", Country = "EE.UU", FundTypeName = "Pasivo", Price = 3500 }
                );
        }
    }
}
