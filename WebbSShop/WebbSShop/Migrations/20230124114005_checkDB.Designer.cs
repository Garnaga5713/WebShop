﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebbSShop.Models;

#nullable disable

namespace WebbSShop.Migrations
{
    [DbContext(typeof(ShoppingContext))]
    [Migration("20230124114005_checkDB")]
    partial class checkDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebbSShop.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("adress");

                    b.Property<int?>("Dicsount")
                        .HasColumnType("int")
                        .HasColumnName("dicsount");

                    b.Property<string>("Fname")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("fname");

                    b.Property<string>("Lname")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("lname");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("WebbSShop.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customer_id");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("datetime")
                        .HasColumnName("order_date");

                    b.Property<int?>("SupermarketId")
                        .HasColumnType("int")
                        .HasColumnName("supermarket_id");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SupermarketId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WebbSShop.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("order_id");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<double?>("Quantity")
                        .HasColumnType("float")
                        .HasColumnName("quantity");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDatails");
                });

            modelBuilder.Entity("WebbSShop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<double?>("Price")
                        .HasColumnType("float")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WebbSShop.Models.SuperMarket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("adress");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("SuperMarkets");
                });

            modelBuilder.Entity("WebbSShop.Models.Order", b =>
                {
                    b.HasOne("WebbSShop.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Orders_Customers");

                    b.HasOne("WebbSShop.Models.SuperMarket", "Supermarket")
                        .WithMany("Orders")
                        .HasForeignKey("SupermarketId")
                        .HasConstraintName("FK_Orders_SuperMarkets");

                    b.Navigation("Customer");

                    b.Navigation("Supermarket");
                });

            modelBuilder.Entity("WebbSShop.Models.OrderDetail", b =>
                {
                    b.HasOne("WebbSShop.Models.Order", "Order")
                        .WithMany("OrderDatails")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_OrderDatails_Orders");

                    b.HasOne("WebbSShop.Models.Product", "Product")
                        .WithMany("OrderDatails")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_OrderDatails_Products");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebbSShop.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("WebbSShop.Models.Order", b =>
                {
                    b.Navigation("OrderDatails");
                });

            modelBuilder.Entity("WebbSShop.Models.Product", b =>
                {
                    b.Navigation("OrderDatails");
                });

            modelBuilder.Entity("WebbSShop.Models.SuperMarket", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
