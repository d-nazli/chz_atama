﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using chz_atama.Data;

#nullable disable

namespace chz_atama.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240902121803_deneme")]
    partial class deneme
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("chz_atama.Models.Cihaz", b =>
                {
                    b.Property<int>("CihazId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CihazId"));

                    b.Property<string>("CihazAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CihazModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CihazSeriNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CihazId");

                    b.ToTable("Cihazs");
                });

            modelBuilder.Entity("chz_atama.Models.CihazAtama", b =>
                {
                    b.Property<int>("AtamaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AtamaId"));

                    b.Property<DateTime?>("AtamaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CihazId")
                        .HasColumnType("int");

                    b.Property<int?>("PersonelId")
                        .HasColumnType("int");

                    b.HasKey("AtamaId");

                    b.HasIndex("CihazId");

                    b.HasIndex("PersonelId");

                    b.ToTable("CihazAtamas");
                });

            modelBuilder.Entity("chz_atama.Models.Departman", b =>
                {
                    b.Property<int>("DepartmanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmanID"));

                    b.Property<string>("DepartmanAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmanID");

                    b.ToTable("Departmans");
                });

            modelBuilder.Entity("chz_atama.Models.Personel", b =>
                {
                    b.Property<int>("PersonelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonelId"));

                    b.Property<int?>("DepartmanId")
                        .HasColumnType("int");

                    b.Property<string>("PersonelAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonelEposta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonelSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonelTel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonelId");

                    b.HasIndex("DepartmanId");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("chz_atama.Models.CihazAtama", b =>
                {
                    b.HasOne("chz_atama.Models.Cihaz", "Cihaz")
                        .WithMany()
                        .HasForeignKey("CihazId");

                    b.HasOne("chz_atama.Models.Personel", "Personel")
                        .WithMany("CihazAtamalar")
                        .HasForeignKey("PersonelId");

                    b.Navigation("Cihaz");

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("chz_atama.Models.Personel", b =>
                {
                    b.HasOne("chz_atama.Models.Departman", "Departman")
                        .WithMany("Personels")
                        .HasForeignKey("DepartmanId");

                    b.Navigation("Departman");
                });

            modelBuilder.Entity("chz_atama.Models.Departman", b =>
                {
                    b.Navigation("Personels");
                });

            modelBuilder.Entity("chz_atama.Models.Personel", b =>
                {
                    b.Navigation("CihazAtamalar");
                });
#pragma warning restore 612, 618
        }
    }
}
