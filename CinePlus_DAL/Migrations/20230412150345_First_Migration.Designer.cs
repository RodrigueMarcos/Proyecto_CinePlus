﻿// <auto-generated />
using System;
using CinePlus_DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CinePlus_DAL.Migrations
{
    [DbContext(typeof(CinePlusDBContext))]
    [Migration("20230412150345_First_Migration")]
    partial class First_Migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CinePlus_DAL.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("clientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("createdByID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("modifiedByID")
                        .HasColumnType("int");

                    b.Property<int>("movScreeningBookID")
                        .HasColumnType("int");

                    b.Property<int>("qtySeats")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("clientID");

                    b.HasIndex("createdByID");

                    b.HasIndex("modifiedByID");

                    b.HasIndex("movScreeningBookID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Booking", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("BookID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("BookID");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Cinema", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("createdByID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("modifiedByID")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("createdByID");

                    b.HasIndex("modifiedByID");

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Genere", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("MovieID")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("createdByID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("modifiedByID")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MovieID");

                    b.HasIndex("createdByID");

                    b.HasIndex("modifiedByID");

                    b.ToTable("Generes");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.MovScreening", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("createdByID")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("modifiedByID")
                        .HasColumnType("int");

                    b.Property<int>("movTheaterID")
                        .HasColumnType("int");

                    b.Property<int>("movType")
                        .HasColumnType("int");

                    b.Property<int>("movieID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("createdByID");

                    b.HasIndex("modifiedByID");

                    b.HasIndex("movTheaterID");

                    b.HasIndex("movieID");

                    b.ToTable("MovScreenings");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.MovTheater", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CinemaID")
                        .HasColumnType("int");

                    b.Property<int>("QtyRows")
                        .HasColumnType("int");

                    b.Property<int>("QtySeats")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("createdByID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("modifiedByID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CinemaID");

                    b.HasIndex("createdByID");

                    b.HasIndex("modifiedByID");

                    b.ToTable("MovTheaters");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("createdByID")
                        .HasColumnType("int");

                    b.Property<int>("directorID")
                        .HasColumnType("int");

                    b.Property<int>("duration")
                        .HasColumnType("int");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("modifiedByID")
                        .HasColumnType("int");

                    b.Property<string>("synopsis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("createdByID");

                    b.HasIndex("directorID");

                    b.HasIndex("modifiedByID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("CinemaID")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MovieID")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("modifiedByID")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("role")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CinemaID");

                    b.HasIndex("MovieID");

                    b.HasIndex("modifiedByID");

                    b.ToTable("People");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Usuario", b =>
                {
                    b.HasBaseType("CinePlus_DAL.Models.Person");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Usuario");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Book", b =>
                {
                    b.HasOne("CinePlus_DAL.Models.Person", "client")
                        .WithMany()
                        .HasForeignKey("clientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinePlus_DAL.Models.Person", "createdBy")
                        .WithMany()
                        .HasForeignKey("createdByID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinePlus_DAL.Models.Person", "modifiedBy")
                        .WithMany()
                        .HasForeignKey("modifiedByID");

                    b.HasOne("CinePlus_DAL.Models.MovScreening", "movScreeningBook")
                        .WithMany()
                        .HasForeignKey("movScreeningBookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("client");

                    b.Navigation("createdBy");

                    b.Navigation("modifiedBy");

                    b.Navigation("movScreeningBook");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Booking", b =>
                {
                    b.HasOne("CinePlus_DAL.Models.Book", null)
                        .WithMany("booking")
                        .HasForeignKey("BookID");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Cinema", b =>
                {
                    b.HasOne("CinePlus_DAL.Models.Person", "createdBy")
                        .WithMany()
                        .HasForeignKey("createdByID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinePlus_DAL.Models.Person", "modifiedBy")
                        .WithMany()
                        .HasForeignKey("modifiedByID");

                    b.Navigation("createdBy");

                    b.Navigation("modifiedBy");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Genere", b =>
                {
                    b.HasOne("CinePlus_DAL.Models.Movie", null)
                        .WithMany("generes")
                        .HasForeignKey("MovieID");

                    b.HasOne("CinePlus_DAL.Models.Person", "createdBy")
                        .WithMany()
                        .HasForeignKey("createdByID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinePlus_DAL.Models.Person", "modifiedBy")
                        .WithMany()
                        .HasForeignKey("modifiedByID");

                    b.Navigation("createdBy");

                    b.Navigation("modifiedBy");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.MovScreening", b =>
                {
                    b.HasOne("CinePlus_DAL.Models.Person", "createdBy")
                        .WithMany()
                        .HasForeignKey("createdByID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinePlus_DAL.Models.Person", "modifiedBy")
                        .WithMany()
                        .HasForeignKey("modifiedByID");

                    b.HasOne("CinePlus_DAL.Models.MovTheater", "movTheater")
                        .WithMany("movScreenings")
                        .HasForeignKey("movTheaterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinePlus_DAL.Models.Movie", "movie")
                        .WithMany()
                        .HasForeignKey("movieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("createdBy");

                    b.Navigation("modifiedBy");

                    b.Navigation("movTheater");

                    b.Navigation("movie");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.MovTheater", b =>
                {
                    b.HasOne("CinePlus_DAL.Models.Cinema", "Cinema")
                        .WithMany("MovTheaters")
                        .HasForeignKey("CinemaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinePlus_DAL.Models.Person", "createdBy")
                        .WithMany()
                        .HasForeignKey("createdByID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinePlus_DAL.Models.Person", "modifiedBy")
                        .WithMany()
                        .HasForeignKey("modifiedByID");

                    b.Navigation("Cinema");

                    b.Navigation("createdBy");

                    b.Navigation("modifiedBy");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Movie", b =>
                {
                    b.HasOne("CinePlus_DAL.Models.Person", "createdBy")
                        .WithMany()
                        .HasForeignKey("createdByID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinePlus_DAL.Models.Person", "director")
                        .WithMany()
                        .HasForeignKey("directorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinePlus_DAL.Models.Person", "modifiedBy")
                        .WithMany()
                        .HasForeignKey("modifiedByID");

                    b.Navigation("createdBy");

                    b.Navigation("director");

                    b.Navigation("modifiedBy");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Person", b =>
                {
                    b.HasOne("CinePlus_DAL.Models.Cinema", null)
                        .WithMany("employees")
                        .HasForeignKey("CinemaID");

                    b.HasOne("CinePlus_DAL.Models.Movie", null)
                        .WithMany("actors")
                        .HasForeignKey("MovieID");

                    b.HasOne("CinePlus_DAL.Models.Person", "modifiedBy")
                        .WithMany()
                        .HasForeignKey("modifiedByID");

                    b.Navigation("modifiedBy");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Book", b =>
                {
                    b.Navigation("booking");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Cinema", b =>
                {
                    b.Navigation("MovTheaters");

                    b.Navigation("employees");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.MovTheater", b =>
                {
                    b.Navigation("movScreenings");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Movie", b =>
                {
                    b.Navigation("actors");

                    b.Navigation("generes");
                });
#pragma warning restore 612, 618
        }
    }
}
