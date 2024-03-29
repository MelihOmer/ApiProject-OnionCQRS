﻿// <auto-generated />
using System;
using ApiProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiProject.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240121165023_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiProject.Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDated = new DateTime(2024, 1, 21, 19, 50, 23, 371, DateTimeKind.Local).AddTicks(4707),
                            IsDeleted = false,
                            Name = "Tools"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDated = new DateTime(2024, 1, 21, 19, 50, 23, 371, DateTimeKind.Local).AddTicks(4749),
                            IsDeleted = false,
                            Name = "Shoes & Jewelery"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDated = new DateTime(2024, 1, 21, 19, 50, 23, 371, DateTimeKind.Local).AddTicks(4760),
                            IsDeleted = true,
                            Name = "Books & Health"
                        });
                });

            modelBuilder.Entity("ApiProject.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDated = new DateTime(2024, 1, 21, 19, 50, 23, 371, DateTimeKind.Local).AddTicks(6681),
                            IsDeleted = false,
                            Name = "Elektronik",
                            ParentId = 0,
                            Priority = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDated = new DateTime(2024, 1, 21, 19, 50, 23, 371, DateTimeKind.Local).AddTicks(6688),
                            IsDeleted = false,
                            Name = "Moda",
                            ParentId = 0,
                            Priority = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedDated = new DateTime(2024, 1, 21, 19, 50, 23, 371, DateTimeKind.Local).AddTicks(6715),
                            IsDeleted = false,
                            Name = "Bilgisayar",
                            ParentId = 1,
                            Priority = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDated = new DateTime(2024, 1, 21, 19, 50, 23, 371, DateTimeKind.Local).AddTicks(6716),
                            IsDeleted = false,
                            Name = "Kadın",
                            ParentId = 2,
                            Priority = 1
                        });
                });

            modelBuilder.Entity("ApiProject.Domain.Entities.Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Details");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDated = new DateTime(2024, 1, 21, 19, 50, 23, 373, DateTimeKind.Local).AddTicks(2620),
                            Description = "Accusantium voluptatem.",
                            IsDeleted = false,
                            Title = "Sıfat."
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            CreatedDated = new DateTime(2024, 1, 21, 19, 50, 23, 373, DateTimeKind.Local).AddTicks(2812),
                            Description = "İure koşuyorlar.",
                            IsDeleted = true,
                            Title = "Nesciunt."
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            CreatedDated = new DateTime(2024, 1, 21, 19, 50, 23, 373, DateTimeKind.Local).AddTicks(2836),
                            Description = "Göze layıkıyla.",
                            IsDeleted = false,
                            Title = "Quasi."
                        });
                });

            modelBuilder.Entity("ApiProject.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CreatedDated = new DateTime(2024, 1, 21, 19, 50, 23, 374, DateTimeKind.Local).AddTicks(7857),
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Discount = 5.302428795720690m,
                            IsDeleted = false,
                            Price = 660.64m,
                            Title = "Unbranded Frozen Chicken"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 3,
                            CreatedDated = new DateTime(2024, 1, 21, 19, 50, 23, 374, DateTimeKind.Local).AddTicks(7991),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Discount = 4.202519645203420m,
                            IsDeleted = false,
                            Price = 642.37m,
                            Title = "Unbranded Fresh Hat"
                        });
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CategoryProduct");
                });

            modelBuilder.Entity("ApiProject.Domain.Entities.Detail", b =>
                {
                    b.HasOne("ApiProject.Domain.Entities.Category", "Category")
                        .WithMany("Details")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ApiProject.Domain.Entities.Product", b =>
                {
                    b.HasOne("ApiProject.Domain.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("ApiProject.Domain.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiProject.Domain.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiProject.Domain.Entities.Category", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
