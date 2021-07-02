﻿// <auto-generated />
using System;
using Example_03;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Example_03.Migrations
{
    [DbContext(typeof(DbContextConfig))]
    [Migration("20210702202900_AddSellerAndBuyerAndProduct")]
    partial class AddSellerAndBuyerAndProduct
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Example_03.Buyer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("purchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("totalBill")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("buyers");
                });

            modelBuilder.Entity("Example_03.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("expireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("productType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("products");
                });

            modelBuilder.Entity("Example_03.Seller", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("license")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("sellers");
                });
#pragma warning restore 612, 618
        }
    }
}
