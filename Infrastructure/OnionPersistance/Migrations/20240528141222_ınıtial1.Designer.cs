﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnionPersistance.Context;

#nullable disable

namespace OnionPersistance.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240528141222_ınıtial1")]
    partial class ınıtial1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CatagoryProduct", b =>
                {
                    b.Property<int>("CatagoriesId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("CatagoriesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CatagoryProduct");
                });

            modelBuilder.Entity("OnionDomain.Common.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 5, 28, 17, 12, 14, 501, DateTimeKind.Local).AddTicks(2814),
                            IsDeleted = false,
                            Name = "Asus"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 5, 28, 17, 12, 14, 501, DateTimeKind.Local).AddTicks(2824),
                            IsDeleted = false,
                            Name = "Apple"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 5, 28, 17, 12, 14, 501, DateTimeKind.Local).AddTicks(2832),
                            IsDeleted = false,
                            Name = "Acer"
                        });
                });

            modelBuilder.Entity("OnionDomain.Common.Entities.Catagory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Priorty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Catagories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 5, 28, 17, 12, 14, 501, DateTimeKind.Local).AddTicks(8634),
                            IsDeleted = false,
                            Name = "Elektronik",
                            ParentId = 0,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 5, 28, 17, 12, 14, 501, DateTimeKind.Local).AddTicks(8642),
                            IsDeleted = false,
                            Name = "Moda",
                            ParentId = 0,
                            Priorty = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 5, 28, 17, 12, 14, 501, DateTimeKind.Local).AddTicks(8649),
                            IsDeleted = false,
                            Name = "Bilgisayar",
                            ParentId = 1,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 5, 28, 17, 12, 14, 501, DateTimeKind.Local).AddTicks(8656),
                            IsDeleted = false,
                            Name = "Kazak",
                            ParentId = 1,
                            Priorty = 2
                        });
                });

            modelBuilder.Entity("OnionDomain.Common.Entities.Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CatagoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
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

                    b.HasIndex("CatagoryId");

                    b.ToTable("Details");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CatagoryId = 1,
                            CreatedDate = new DateTime(2024, 5, 28, 17, 12, 14, 502, DateTimeKind.Local).AddTicks(2747),
                            Description = "RTX4090",
                            IsDeleted = false,
                            Title = "EkranKartı"
                        },
                        new
                        {
                            Id = 2,
                            CatagoryId = 3,
                            CreatedDate = new DateTime(2024, 5, 28, 17, 12, 14, 502, DateTimeKind.Local).AddTicks(2757),
                            Description = "DDR5",
                            IsDeleted = true,
                            Title = "Ram"
                        },
                        new
                        {
                            Id = 3,
                            CatagoryId = 4,
                            CreatedDate = new DateTime(2024, 5, 28, 17, 12, 14, 502, DateTimeKind.Local).AddTicks(2764),
                            Description = "Yün",
                            IsDeleted = false,
                            Title = "Hammadde"
                        });
                });

            modelBuilder.Entity("OnionDomain.Common.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desciription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Tittle")
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
                            CreatedDate = new DateTime(2024, 5, 28, 17, 12, 14, 502, DateTimeKind.Local).AddTicks(6955),
                            Desciription = "blablabla",
                            Discount = 15m,
                            IsDeleted = false,
                            Price = 15000m,
                            Tittle = "Asusz9"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 2,
                            CreatedDate = new DateTime(2024, 5, 28, 17, 12, 14, 502, DateTimeKind.Local).AddTicks(6966),
                            Desciription = "blablabla",
                            Discount = 15m,
                            IsDeleted = false,
                            Price = 15000m,
                            Tittle = "macbook"
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 3,
                            CreatedDate = new DateTime(2024, 5, 28, 17, 12, 14, 502, DateTimeKind.Local).AddTicks(6975),
                            Desciription = "blablabla",
                            Discount = 15m,
                            IsDeleted = false,
                            Price = 15000m,
                            Tittle = "aspire"
                        });
                });

            modelBuilder.Entity("CatagoryProduct", b =>
                {
                    b.HasOne("OnionDomain.Common.Entities.Catagory", null)
                        .WithMany()
                        .HasForeignKey("CatagoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnionDomain.Common.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnionDomain.Common.Entities.Detail", b =>
                {
                    b.HasOne("OnionDomain.Common.Entities.Catagory", "Catagory")
                        .WithMany("Details")
                        .HasForeignKey("CatagoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Catagory");
                });

            modelBuilder.Entity("OnionDomain.Common.Entities.Product", b =>
                {
                    b.HasOne("OnionDomain.Common.Entities.Brand", "brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("brand");
                });

            modelBuilder.Entity("OnionDomain.Common.Entities.Catagory", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
