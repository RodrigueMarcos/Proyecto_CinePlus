﻿// <auto-generated />
using System;
using CinePlus_DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CinePlus_DAL.Migrations
{
    [DbContext(typeof(CinePlusDBContext))]
    [Migration("20230414045543_Second_Migration")]
    partial class Second_Migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CinePlus_DAL.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<int?>("ModifiedById")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("MovScreeningID")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("firstSeat")
                        .HasColumnType("int");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("qtySeats")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Cinema", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<int?>("ModifiedById")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ID");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Genere", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<int?>("ModifiedById")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ID");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.ToTable("Generes");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.MovScreening", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ModifiedById")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("MovTheaterId")
                        .HasColumnType("int");

                    b.Property<string>("MovType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ID");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("MovTheaterId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovScreenings");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.MovTheater", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<int?>("ModifiedById")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("QtyRows")
                        .HasColumnType("int");

                    b.Property<int>("QtySeats")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ID");

                    b.HasIndex("CinemaId");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.ToTable("MovTheaters");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<int>("DirectorID")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int?>("ModifiedById")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Synopsis")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ID");

                    b.HasIndex("CreatedById");

                    b.HasIndex("DirectorID");

                    b.HasIndex("ModifiedById");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.MovieGenere", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("GenereID")
                        .HasColumnType("int");

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GenereID");

                    b.HasIndex("MovieID");

                    b.ToTable("MovieGeneres");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.MoviePerson", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MovieId");

                    b.HasIndex("PersonId");

                    b.ToTable("MoviePeople");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("modifiedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("ModifiedById");

                    b.ToTable("People");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Book", b =>
                {
                    b.HasOne("CinePlus_DAL.Models.Person", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinePlus_DAL.Models.Person", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("ModifiedBy");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Cinema", b =>
                {
                    b.HasOne("CinePlus_DAL.Models.Person", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinePlus_DAL.Models.Person", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("ModifiedBy");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Genere", b =>
                {
                    b.HasOne("CinePlus_DAL.Models.Person", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinePlus_DAL.Models.Person", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("ModifiedBy");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.MovScreening", b =>
                {
                    b.HasOne("CinePlus_DAL.Models.Person", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinePlus_DAL.Models.Person", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinePlus_DAL.Models.MovTheater", "MovTheater")
                        .WithMany()
                        .HasForeignKey("MovTheaterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinePlus_DAL.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("ModifiedBy");

                    b.Navigation("MovTheater");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.MovTheater", b =>
                {
                    b.HasOne("CinePlus_DAL.Models.Cinema", "Cinema")
                        .WithMany()
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinePlus_DAL.Models.Person", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinePlus_DAL.Models.Person", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("CreatedBy");

                    b.Navigation("ModifiedBy");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Movie", b =>
                {
                    b.HasOne("CinePlus_DAL.Models.Person", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinePlus_DAL.Models.Person", "Director")
                        .WithMany()
                        .HasForeignKey("DirectorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinePlus_DAL.Models.Person", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("Director");

                    b.Navigation("ModifiedBy");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.MovieGenere", b =>
                {
                    b.HasOne("CinePlus_DAL.Models.Genere", "Genere")
                        .WithMany("MovieGeneres")
                        .HasForeignKey("GenereID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinePlus_DAL.Models.Movie", "Movie")
                        .WithMany("MovieGeneres")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genere");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.MoviePerson", b =>
                {
                    b.HasOne("CinePlus_DAL.Models.Movie", "Movie")
                        .WithMany("MoviePersons")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinePlus_DAL.Models.Person", "Person")
                        .WithMany("MoviePersons")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Person", b =>
                {
                    b.HasOne("CinePlus_DAL.Models.Person", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById");

                    b.Navigation("ModifiedBy");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Genere", b =>
                {
                    b.Navigation("MovieGeneres");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Movie", b =>
                {
                    b.Navigation("MovieGeneres");

                    b.Navigation("MoviePersons");
                });

            modelBuilder.Entity("CinePlus_DAL.Models.Person", b =>
                {
                    b.Navigation("MoviePersons");
                });
#pragma warning restore 612, 618
        }
    }
}
