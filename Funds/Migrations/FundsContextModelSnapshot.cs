﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Funds.Data;

namespace Funds.Migrations
{
    [DbContext(typeof(FundsContext))]
    partial class FundsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("Funds.Data.Fund", b =>
                {
                    b.Property<int>("FundId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("FundTypeName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("FundId");

                    b.HasIndex("FundTypeName");

                    b.ToTable("Funds");

                    b.HasData(
                        new
                        {
                            FundId = 1,
                            Country = "España",
                            FundTypeName = "Activo",
                            Name = "True value",
                            Price = 850f
                        },
                        new
                        {
                            FundId = 2,
                            Country = "España",
                            FundTypeName = "Activo",
                            Name = "Cobas",
                            Price = 1020f
                        },
                        new
                        {
                            FundId = 3,
                            Country = "EE.UU",
                            FundTypeName = "Pasivo",
                            Name = "Índice SP500",
                            Price = 3500f
                        });
                });

            modelBuilder.Entity("Funds.Data.FundType", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("FundTypes");

                    b.HasData(
                        new
                        {
                            Name = "Activo"
                        },
                        new
                        {
                            Name = "Pasivo"
                        },
                        new
                        {
                            Name = "Híbrido"
                        });
                });

            modelBuilder.Entity("Funds.Data.Fund", b =>
                {
                    b.HasOne("Funds.Data.FundType", "FundType")
                        .WithMany("Funds")
                        .HasForeignKey("FundTypeName");
                });
#pragma warning restore 612, 618
        }
    }
}
