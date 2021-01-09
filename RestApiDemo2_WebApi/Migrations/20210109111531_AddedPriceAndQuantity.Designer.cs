﻿// <auto-generated />

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using RestApiDemo_WebApi.Data;

namespace RestApiDemo_WebApi.Migrations
{
    [DbContext(typeof(BaseItemContext))]
    [Migration("20210109111531_AddedPriceAndQuantity")]
    partial class AddedPriceAndQuantity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("RestApiDemo2_WebApi.Models.Cookware", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cookwares");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Plate",
                            Price = 4.50m,
                            Quantity = 40
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fork",
                            Price = 2.90m,
                            Quantity = 80
                        },
                        new
                        {
                            Id = 3,
                            Name = "Spoon",
                            Price = 1.90m,
                            Quantity = 60
                        });
                });

            modelBuilder.Entity("RestApiDemo2_WebApi.Models.Fruit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Fruits");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Apple",
                            Price = 0.50m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 2,
                            Name = "Pear",
                            Price = 1.20m,
                            Quantity = 20
                        },
                        new
                        {
                            Id = 3,
                            Name = "Orange",
                            Price = 0.79m,
                            Quantity = 50
                        });
                });

            modelBuilder.Entity("RestApiDemo2_WebApi.Models.Vegetable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Vegetables");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Carrot",
                            Price = 0.45m,
                            Quantity = 120
                        },
                        new
                        {
                            Id = 2,
                            Name = "Beet",
                            Price = 0.65m,
                            Quantity = 14
                        },
                        new
                        {
                            Id = 3,
                            Name = "Onion",
                            Price = 0.20m,
                            Quantity = 5
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
