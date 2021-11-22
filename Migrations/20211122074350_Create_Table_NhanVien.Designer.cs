﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCore.Data;

namespace NetCore.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20211122074350_Create_Table_NhanVien")]
    partial class Create_Table_NhanVien
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("NetCore.Models.HoaDon", b =>
                {
                    b.Property<string>("HoaDonID")
                        .HasColumnType("TEXT");

                    b.Property<int>("KhachHangID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("TEXT");

                    b.HasKey("HoaDonID");

                    b.HasIndex("KhachHangID");

                    b.ToTable("HoaDons");
                });

            modelBuilder.Entity("NetCore.Models.KhachHang", b =>
                {
                    b.Property<int>("KhachHangID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("SoDienThoai")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenKhachHang")
                        .HasColumnType("TEXT");

                    b.HasKey("KhachHangID");

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("NetCore.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("NetCore.Models.NhanVien", b =>
                {
                    b.Property<string>("TenNhanVien")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChucVu")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhongBanID")
                        .HasColumnType("TEXT");

                    b.HasKey("TenNhanVien");

                    b.HasIndex("PhongBanID");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("NetCore.Models.Person", b =>
                {
                    b.Property<string>("CCCD")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.HasKey("CCCD");

                    b.ToTable("Persons");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("NetCore.Models.PhongBan", b =>
                {
                    b.Property<string>("PhongBanID")
                        .HasColumnType("TEXT");

                    b.Property<string>("TangLamViec")
                        .HasColumnType("TEXT");

                    b.HasKey("PhongBanID");

                    b.ToTable("PhongBans");
                });

            modelBuilder.Entity("NetCore.Models.Student", b =>
                {
                    b.HasBaseType("NetCore.Models.Person");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaSinhVien")
                        .HasColumnType("TEXT");

                    b.Property<string>("University")
                        .HasColumnType("TEXT");

                    b.ToTable("Persons");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("NetCore.Models.HoaDon", b =>
                {
                    b.HasOne("NetCore.Models.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("KhachHangID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("NetCore.Models.NhanVien", b =>
                {
                    b.HasOne("NetCore.Models.PhongBan", "PhongBan")
                        .WithMany("NhanViens")
                        .HasForeignKey("PhongBanID");

                    b.Navigation("PhongBan");
                });

            modelBuilder.Entity("NetCore.Models.KhachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("NetCore.Models.PhongBan", b =>
                {
                    b.Navigation("NhanViens");
                });
#pragma warning restore 612, 618
        }
    }
}