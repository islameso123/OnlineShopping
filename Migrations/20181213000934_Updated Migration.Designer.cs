﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineShopping.Models;

namespace OnlineShopping.Migrations
{
    [DbContext(typeof(ShoppingContext))]
    [Migration("20181213000934_Updated Migration")]
    partial class UpdatedMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineShopping.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("OnlineShopping.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address");

                    b.Property<DateTime>("birthDate");

                    b.Property<string>("email");

                    b.Property<bool>("gender");

                    b.Property<string>("name");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("OnlineShopping.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cID");

                    b.Property<DateTime>("deliveryTime");

                    b.Property<decimal>("discount");

                    b.Property<DateTime>("orderDate");

                    b.Property<int>("productID");

                    b.Property<int>("quantity");

                    b.Property<decimal>("totalPrice");

                    b.HasKey("ID");

                    b.HasIndex("cID");

                    b.HasIndex("productID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OnlineShopping.Models.Payment", b =>
                {
                    b.Property<int>("cID");

                    b.Property<int>("oID");

                    b.Property<DateTime>("paymantDate");

                    b.HasKey("cID", "oID");

                    b.HasIndex("oID")
                        .IsUnique();

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("OnlineShopping.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("catID");

                    b.Property<string>("name");

                    b.Property<decimal>("price");

                    b.Property<int>("siD");

                    b.Property<int>("stock");

                    b.HasKey("ID");

                    b.HasIndex("catID");

                    b.HasIndex("siD");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("OnlineShopping.Models.Supplier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("location");

                    b.Property<string>("name");

                    b.HasKey("ID");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("OnlineShopping.Models.Order", b =>
                {
                    b.HasOne("OnlineShopping.Models.Customer", "customer")
                        .WithMany("_orders")
                        .HasForeignKey("cID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OnlineShopping.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineShopping.Models.Payment", b =>
                {
                    b.HasOne("OnlineShopping.Models.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("cID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OnlineShopping.Models.Order", "order")
                        .WithOne("payment")
                        .HasForeignKey("OnlineShopping.Models.Payment", "oID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineShopping.Models.Product", b =>
                {
                    b.HasOne("OnlineShopping.Models.Category", "category")
                        .WithMany("products")
                        .HasForeignKey("catID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OnlineShopping.Models.Supplier", "supplier")
                        .WithMany("products")
                        .HasForeignKey("siD")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}