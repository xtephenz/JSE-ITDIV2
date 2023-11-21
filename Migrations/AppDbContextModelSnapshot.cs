﻿// <auto-generated />
using System;
using JSE.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JSE.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JSE.Models.Admin", b =>
                {
                    b.Property<Guid>("admin_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("admin_password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("admin_username")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("admin_id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("JSE.Models.Courier", b =>
                {
                    b.Property<Guid>("courier_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("courier_name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("courier_phone")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.HasKey("courier_id");

                    b.ToTable("Courier");
                });

            modelBuilder.Entity("JSE.Models.Delivery", b =>
                {
                    b.Property<Guid>("tracking_number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("arrival_date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("courier_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("delivery_price")
                        .HasColumnType("int");

                    b.Property<string>("delivery_status")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("package_weight")
                        .HasColumnType("int");

                    b.Property<Guid>("pool_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("receiver_address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("receiver_name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("receiver_phone")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("sender_address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("sender_name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("sender_phone")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<DateTime>("sending_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("service_type")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("tracking_number");

                    b.HasIndex("courier_id");

                    b.HasIndex("pool_id");

                    b.ToTable("Delivery");
                });

            modelBuilder.Entity("JSE.Models.PoolBranch", b =>
                {
                    b.Property<Guid>("pool_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("pool_address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("pool_phone")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.HasKey("pool_id");

                    b.ToTable("PoolBranch");
                });

            modelBuilder.Entity("JSE.Models.Delivery", b =>
                {
                    b.HasOne("JSE.Models.Courier", "Courier")
                        .WithMany()
                        .HasForeignKey("courier_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JSE.Models.PoolBranch", "PoolBranch")
                        .WithMany()
                        .HasForeignKey("pool_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courier");

                    b.Navigation("PoolBranch");
                });
#pragma warning restore 612, 618
        }
    }
}
